using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Award;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Shared;
using IMSBackend.Domain.UseCases;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Command.Voting
{
    public class CastVoteCommandHandler : IRequestHandler<CastVoteCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentService _paymentService;

        public CastVoteCommandHandler(IUnitOfWork unitOfWork, IPaymentService paymentService)
        {
            _unitOfWork = unitOfWork;
            _paymentService = paymentService;
        }

        public async Task<Result<string>> Handle(CastVoteCommand cmd, CancellationToken cancellationToken)
        {
            decimal amountExpected = cmd.Quantity * 50;
            var paymentResult = await _paymentService.GetTransactionStatus(cmd.ReferenceNumber);

            if (paymentResult is  null)
                return await Result<string>.FailureAsync("Unable to verify transaction");

            var payment = paymentResult.data;

            // ✅ Match expected vs actual amount from Flutterwave
            bool amountMatches = Math.Round(amountExpected) == Math.Round(payment.amount);

            var pay = new Payment
            {
                UserId = cmd.NomineeId,
                Amount = payment.amount,
                Status = amountMatches
                ? PaymentStatus.Successful.ToString()
                : PaymentStatus.Incomplete.ToString(),
                TransactionReference = cmd.ReferenceNumber,
                AmountExpected = amountExpected,
               
            };
            await _unitOfWork.PaymentRepository.AddAsync(pay);
            await _unitOfWork.Save(cancellationToken);
     
            if (pay.Status  == PaymentStatus.Successful.ToString())
            {
                var castVote = new Vote
                {
                    NomineeId = cmd.NomineeId,
                    PaymentId = pay.Id,
                    AmountPaid = payment.amount,
                    VoterEmail = cmd.VoterEmail,
                    VoterName = cmd.VoterName,
                    PaymentStatus = pay.Status,
                };
                await _unitOfWork.VoteRepository.AddAsync(castVote);
                await _unitOfWork.Save(cancellationToken);
                return await Result<string>.SuccessAsync("Vote cast successfully.");
            }
            return await Result<string>.FailureAsync("Vote casting failed due to invalid amount paid");

        }
    }
}
