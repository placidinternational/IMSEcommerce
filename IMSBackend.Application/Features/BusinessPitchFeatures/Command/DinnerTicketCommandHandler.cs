using IMSBackend.Application.Contracts;
using IMSBackend.Application.Services;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Command
{
    public class DinnerTicketCommandHandler : IRequestHandler<DinnerTicketCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentService _paymentService;

        public DinnerTicketCommandHandler(IUnitOfWork unitOfWork, IPaymentService paymentService)
        {
            _unitOfWork = unitOfWork;
            _paymentService = paymentService;
        }
        public async Task<Result<string>> Handle(DinnerTicketCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var payment = await _paymentService.GetTransactionStatus(request.ReferenceNumber);
                if (payment == null)
                {
                    return await Result<string>.FailureAsync("Payment cannot be null");
                }

                var ticket = await _unitOfWork.DinnerTicketRepository.AddAsync(new Domain.Entities.BusinessPitches.DinnerTicket
                {
                    FullName = request.FullName,
                    EmailAddress = request.EmailAddress,
                    PhoneNumber = request.PhoneNumber,
                    TicketType = request.TicketType,
                    TicketCode = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper(),
                    Address = request.Address,
                    Quantity = request.Quantity,
                    AmountPaid = payment.data.amount,
                    Price = request.Price,

                });
                await _unitOfWork.Save(cancellationToken);

                if (ticket == null)
                {
                    return await Result<string>.FailureAsync("failed to create");
                }

                else
                {
                    var pay = new Payment
                    {
                        Amount = payment.data.amount,
                        TransactionReference = request.ReferenceNumber,
                        TicketId = ticket.Id,
                        Status = PaymentStatus.Successful.ToString(),
                    };
                    await _unitOfWork.PaymentRepository.AddAsync(pay);
                    await _unitOfWork.Save(cancellationToken);

                    return await Result<string>.SuccessAsync("created successfully");
                }
            }
            catch (Exception ex)
            {
                return await Result<string>.FailureAsync("error");
            }
        }
    }
}
