using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.OrderDto;
using IMSBackend.Application.Features.ProductCategories.Command.Create;
using IMSBackend.Common;
using IMSBackend.Domain.Entities.CustomerDomain;
using IMSBackend.Domain.Entities.OrderDomain;
using IMSBackend.Domain.Entities.Product;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Shared;
using IMSBackend.Infrastructure.Settings;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twilio.TwiML.Messaging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace IMSBackend.Application.Features.CheckoutFeatures
{
    public class ProcessProductOrderCommandHandler : IRequestHandler<ProcessProductOrderCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentService _paymentService;
        private readonly ILogger<ProcessProductOrderCommandHandler> _logger;
        private readonly CheckoutSettings _settings; // NEW: Injected settings

        public ProcessProductOrderCommandHandler(IUnitOfWork unitOfWork, IPaymentService paymentService, IOptions<CheckoutSettings> options, ILogger<ProcessProductOrderCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _paymentService = paymentService;
            _logger = logger;
            _settings = options.Value;
        }

        public async Task<Result<string>> Handle(ProcessProductOrderCommand request, CancellationToken cancellationToken)
        {
            var strategy = _unitOfWork.GetExecutionStrategy();
            var checkoutDto = request.CheckoutDto;

            try
            {
                // 1. Wrap the entire atomic operation inside ExecuteAsync for retry logic.
                // FIX: Explicitly cast to IExecutionStrategy to guide the compiler 
                // toward the overload that takes a Func<CancellationToken, Task<TResult>>
                return await strategy.ExecuteAsync(
                    async (token) => // Delegate accepts a CancellationToken
                    {
                        // Start the transaction manually with Serializable isolation level.
                        await using var transaction = await _unitOfWork.BeginTransactionAsync(IsolationLevel.Serializable, token);

                        try
                        {
                            decimal subtotal = 0;
                            decimal taxableSubtotal = 0;
                            var vendorIdsInOrder = new HashSet<Guid>();

                            // Map to store product details needed for order creation (safe copies inside transaction)
                            var productMap = new Dictionary<Guid, (decimal Price, Guid VendorId, string Name, int Stock, Product Entity)>();
                            var vendorTaxSettings = new Dictionary<Guid, bool>();

                            // 2. Initial Stock Check and Expected Total Calculation
                            foreach (var itemDto in checkoutDto.CartItems)
                            {
                                // Retrieve the product entity with tracking. Use the token.
                                var product = await _unitOfWork.ProductRepository.FindByFirstOrDefaultAsync(p => p.Id == itemDto.ProductId, token);

                                // Check 1: Existence and Stock Availability
                                if (product == null || product.Quantity < itemDto.Quantity)
                                {
                                    await transaction.RollbackAsync(token); // Use token
                                    string message = product == null
                                        ? "Product not found."
                                        : $"Stock insufficient for {product.Name}. Available: {product.Quantity}, Requested: {itemDto.Quantity}.";
                                    _logger.LogInformation(message);
                                    return await Result<string>.FailureAsync("Product quantity less than the selected quantity");
                                }

                                // Get or cache the vendor's tax preference
                                Guid vendorId = product.VendorId;
                                if (!vendorTaxSettings.ContainsKey(vendorId))
                                {
                                    // Fetch Vendor details. Use the token.
                                    var vendor = await _unitOfWork.VendorsRepository.FindBySingleOrDefaultAsync(v => v.Id == vendorId, token);

                                    // Default to FALSE if vendor settings are not found
                                    vendorTaxSettings[vendorId] = vendor?.PassTaxToCustomer ?? false;
                                }

                                // Calculate item subtotal
                                decimal itemSubtotal = product.CostPrice * itemDto.Quantity;
                                subtotal += itemSubtotal;

                                // Apply item subtotal to taxable total ONLY IF vendor passes tax on
                                if (vendorTaxSettings[vendorId])
                                {
                                    taxableSubtotal += itemSubtotal;
                                }

                                // Store entity reference and details for later use
                                productMap[product.Id] = (
                                    product.CostPrice,
                                    product.VendorId,
                                    product.Name,
                                    product.Quantity,
                                    product
                                );
                            }

                            // Finalize Expected Amount Calculation
                            decimal taxAmount = taxableSubtotal * _settings.TaxRate;
                            decimal feeAmount = subtotal * _settings.PaymentGatewayCharges;
                            decimal finalTotalExpected = subtotal + taxAmount + feeAmount;

                            // 3. PAYMENT VERIFICATION (CRITICAL STEP)
                            var paymentResult = await _paymentService.GetTransactionStatus(checkoutDto.ReferenceNumber);

                            if (paymentResult?.data == null || paymentResult.status?.ToLower() != "success")
                            {
                                await transaction.RollbackAsync(token); // Use token
                                _logger.LogInformation($"Payment verification failed or transaction was not successful for this reference {checkoutDto.ReferenceNumber}");
                                return await Result<string>.FailureAsync("Payment verification failed or transaction was not successful.");
                            }

                            // Verify that the amount paid matches the expected final total
                            bool amountMatches = (Math.Round(finalTotalExpected, 2) == Math.Round(paymentResult.data.amount, 2) || Math.Round(paymentResult.data.amount, 2) > Math.Round(finalTotalExpected, 2));

                            if (!amountMatches)
                            {
                                await transaction.RollbackAsync(token); // Use token
                                string message = $"Payment verification failed: Expected amount {finalTotalExpected:N2} does not match actual amount {paymentResult.data.amount:N2}. A potential fraud attempt has been flagged.";
                                _logger.LogInformation(message);
                                return await Result<string>.FailureAsync(message);
                            }

                            // 4. Stock Deduction, Order Creation, and CRM Update
                            var newOrder = new Order
                            {
                                Items = new List<OrderItem>(),
                                CustomerId = checkoutDto.CustomerId,
                                TaxRate = _settings.TaxRate,
                                PaymentFeeRate = _settings.PaymentGatewayCharges,
                                Subtotal = subtotal,
                                TaxAmount = taxAmount,
                                FeeAmount = feeAmount,
                                FinalTotalPaid = finalTotalExpected,
                            };

                            foreach (var itemDto in checkoutDto.CartItems)
                            {
                                var productData = productMap[itemDto.ProductId];
                                var productToDeduct = productData.Entity;

                                // Deduct stock in memory (the entity is already tracked from step 2)
                                productToDeduct.Quantity -= itemDto.Quantity;
                                // Update is implicit since the entity is tracked (no explicit Update call needed)

                                // Build the Order Item
                                var orderItem = new OrderItem
                                {
                                    ProductId = itemDto.ProductId,
                                    ProductName = productData.Name,
                                    Quantity = itemDto.Quantity,
                                    UnitPrice = productData.Price,
                                    VendorId = productData.VendorId,
                                };

                                newOrder.Items.Add(orderItem);
                                vendorIdsInOrder.Add(productData.VendorId);
                            }

                            // Add the fully populated Order entity to the context. Use the token.
                            await _unitOfWork.OrderRepository.AddAsync(newOrder);

                            // Update Vendor-Customer CRM Relationship
                            var customerId = newOrder.CustomerId;
                            var now = DateTime.UtcNow;

                            foreach (var vendorId in vendorIdsInOrder)
                            {
                                // Check if the VendorCustomer record already exists. Use the token.
                                var existingRelationship = await _unitOfWork.VendorCustomerRepository.FindByFirstOrDefaultAsync(vc => vc.VendorId == vendorId && vc.CustomerId == customerId, token);

                                if (existingRelationship == null)
                                {
                                    // If it doesn't exist, add it. Use the token.
                                    await _unitOfWork.VendorCustomerRepository.AddAsync(new VendorCustomer
                                    {
                                        VendorId = vendorId,
                                        CustomerId = customerId,
                                        LastPurchaseDate = now
                                    });
                                }
                                else
                                {
                                    // If it exists, update the last purchase date.
                                    existingRelationship.LastPurchaseDate = now;
                                    existingRelationship.DateCreated = DateTime.UtcNow;
                                    // Assuming Update is needed to ensure tracking (if not already tracked)
                                    // We keep the update call here, unlike the event handler, as the VendorCustomer isn't loaded earlier.
                                    await _unitOfWork.VendorCustomerRepository.Update(existingRelationship);
                                }
                            }

                            // 5. Final Save and Commit. Use the token.
                            await _unitOfWork.Save(token);
                            await transaction.CommitAsync(token);

                            _logger.LogInformation($"Order placed successfully! Payment verified.{newOrder.Id}");
                            return await Result<string>.SuccessAsync($"Order placed successfully! Payment verified.{newOrder.Id}");
                        }
                        catch (Exception)
                        {
                            // Rollback on any internal failure before the exception propagates
                            await transaction.RollbackAsync(token); // Use token
                            throw; // Re-throw for the Execution Strategy to handle (retry or bubble up)
                        }
                    },
                    cancellationToken // Passing the mandatory cancellation token for ExecuteAsync
                );
            }
            catch (Exception ex)
            {
                // Catch any exception that escapes the retry block.
                _logger.LogError(ex, "A critical error occurred during product order execution. The transaction was automatically rolled back by the execution strategy.");
                return await Result<string>.FailureAsync("An unexpected error occurred during checkout.");
            }
        }
    }
    
}
