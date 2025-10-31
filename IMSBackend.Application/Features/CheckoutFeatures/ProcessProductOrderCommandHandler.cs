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
            var checkoutDto =request.CheckoutDto;

            // Use a database transaction to ensure all subsequent state changes are atomic.
            // IsolationLevel.Serializable prevents concurrent stock updates (Phantom reads).
            using var transaction = await _unitOfWork.BeginTransactionAsync(IsolationLevel.Serializable, cancellationToken);

            try
            {
                decimal subtotal = 0;
               
                decimal taxableSubtotal = 0; 
                    // Map to store product details needed for order creation (safe copies inside transaction)
                    var productMap = new Dictionary<Guid, (decimal Price, Guid VendorId, string Name, int Stock, Product Entity)>();
                var vendorTaxSettings = new Dictionary<Guid, bool>();

                // 1. Initial Stock Check and Expected Total Calculation
                foreach (var itemDto in checkoutDto.CartItems)
                {
                    // Retrieve the product entity with tracking for later deduction
                    var product = await _unitOfWork.ProductRepository.FindByFirstOrDefaultAsync(p => p.Id == itemDto.ProductId, cancellationToken);

                    // Check 1: Existence and Stock Availability
                    if (product == null || product.Quantity < itemDto.Quantity)
                    {
                        await transaction.RollbackAsync(cancellationToken);
                        string message = product == null
                            ? "Product not found."
                            : $"Stock insufficient for {product.Name}. Available: {product.Quantity}, Requested: {itemDto.Quantity}.";
                        _logger.LogInformation(message);
                        return await Result<string>.FailureAsync("Product quantity less than the selected quantity");
                        
                    }

                    //// Calculate subtotal contribution based on current price
                    //subtotal += product.CostPrice * itemDto.Quantity;

                    // Get or cache the vendor's tax preference
                    Guid vendorId = product.VendorId;
                    if (!vendorTaxSettings.ContainsKey(vendorId))
                    {
                        var vendor = await _unitOfWork.VendorsRepository.FindBySingleOrDefaultAsync(v => v.Id == vendorId, cancellationToken);

                        // Default to FALSE if vendor settings are not found
                        vendorTaxSettings[vendorId] = vendor?.PassTaxToCustomer ?? false;
                    }

                    // Calculate item subtotal
                    decimal itemSubtotal = product.CostPrice * itemDto.Quantity;
                    subtotal += itemSubtotal;

                    // NEW: Apply item subtotal to taxable total ONLY IF vendor passes tax on
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
                decimal taxAmount = subtotal * _settings.TaxRate;
                decimal feeAmount = subtotal * _settings.PaymentGatewayCharges;
                decimal finalTotalExpected = subtotal + taxAmount + feeAmount;

                // 3. PAYMENT VERIFICATION (CRITICAL STEP)
                var paymentResult = await _paymentService.GetTransactionStatus(checkoutDto.ReferenceNumber);

                if (paymentResult?.data == null || paymentResult.status?.ToLower() != "success")
                {
                    await transaction.RollbackAsync(cancellationToken);
                    _logger.LogInformation($"Payment verification failed or transaction was not successful for this reference {checkoutDto.ReferenceNumber}");
                    return await Result<string>.FailureAsync("Payment verification failed or transaction was not successful.");
                }

                // Verify that the amount paid matches the expected final total
                bool amountMatches = Math.Round(finalTotalExpected, 2) == Math.Round(paymentResult.data.amount, 2) || Math.Round(finalTotalExpected, 2) > Math.Round(paymentResult.data.amount, 2);

                if (!amountMatches)
                {
                    await transaction.RollbackAsync(cancellationToken);
                    // Log detailed mismatch for security/fraud audit
                   // Reverted to tuple return
                   _logger.LogInformation($"Payment verification failed: Expected amount {finalTotalExpected:N2} does not match actual amount {paymentResult.data.amount:N2}. A potential fraud attempt has been flagged.");
                    return await Result<string>.FailureAsync($"Payment verification failed: Expected amount {finalTotalExpected:N2} does not match actual amount {paymentResult.data.amount:N2}. A potential fraud attempt has been flagged.");
                }
                // Payment is verified and amount is correct. Proceed with state changes.

                // tock Deduction, Order Creation, and CRM Update
                var newOrder = new Order
                {
                    Items = new List<OrderItem>(),
                    CustomerEmail = checkoutDto.CustomerEmail,
                    TaxRate = _settings.TaxRate,
                    PaymentFeeRate = _settings.PaymentGatewayCharges,
                    Subtotal = subtotal,
                    TaxAmount = taxAmount,
                    FeeAmount = feeAmount,
                    FinalTotalPaid = finalTotalExpected,
                };

                var vendorIdsInOrder = new HashSet<Guid>();

                foreach (var itemDto in checkoutDto.CartItems)
                {
                    var productData = productMap[itemDto.ProductId];
                    var productToDeduct = productData.Entity;

                    // Deduct stock in memory (the entity is already tracked from step 1)
                    productToDeduct.Quantity -= itemDto.Quantity;
                    // Update is implicit since the entity is tracked

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

                await _unitOfWork.OrderRepository.AddAsync(newOrder);

                // Update Vendor-Customer CRM Relationship
                var customerEmail = newOrder.CustomerEmail;
                var now = DateTime.UtcNow;

                foreach (var vendorId in vendorIdsInOrder)
                {
                    var existingRelationship = await _unitOfWork.VendorCustomerRepository.FindByFirstOrDefaultAsync(vc => vc.VendorId == vendorId && vc.CustomerEmail == customerEmail, cancellationToken);

                    if (existingRelationship == null)
                    {
                       await _unitOfWork.VendorCustomerRepository.AddAsync(new VendorCustomer
                        {
                            VendorId = vendorId,
                            CustomerEmail = customerEmail,
                            LastPurchaseDate = now
                        });
                    }
                    else
                    {
                        existingRelationship.LastPurchaseDate = now;
                        existingRelationship.DateCreated = DateTime.UtcNow;
                       await _unitOfWork.VendorCustomerRepository.Update(existingRelationship);
                    }
                }

                // 6. Final Save and Commit
                await _unitOfWork.Save(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
                // Reverted to tuple return
                _logger.LogInformation($"Order placed successfully! Payment verified.{newOrder.Id}");
                return await Result<string>.SuccessAsync($"Order placed successfully! Payment verified.{newOrder.Id}");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync(cancellationToken);
                // Log the exception for debugging purposes
                _logger.LogInformation("An unexpected error occurred during checkout.");
                return await Result<string>.FailureAsync("An unexpected error occurred during checkout."); // Reverted to tuple return
            }
        }
    }
}
