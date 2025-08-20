using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Domain.Entities.Award;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Shared;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Migrations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Command.Voting
{
    public class CastVoteCommandHandler : IRequestHandler<CastVoteCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentService _paymentService;
        private readonly IJobTestService _jobTestService;

        public CastVoteCommandHandler(IUnitOfWork unitOfWork, IPaymentService paymentService, IJobTestService jobTestService)
        {
            _unitOfWork = unitOfWork;
            _paymentService = paymentService;
            _jobTestService = jobTestService;
        }

        public async Task<Result<string>> Handle(CastVoteCommand cmd, CancellationToken cancellationToken)
        {
            try
            {
                var nominee = await _unitOfWork.NomineeRepository.GetQueryable().Include(x => x.Account).Where(x => x.AccountId == cmd.NomineeId).FirstOrDefaultAsync();
                if (nominee == null)
                {
                    return await Result<string>.FailureAsync("Nominee cannot be found");
                }
                decimal amountExpected = cmd.Quantity * 50;
                var paymentResult = await _paymentService.GetTransactionStatus(cmd.ReferenceNumber);

                if (paymentResult.data is null)
                {
                    return await Result<string>.FailureAsync("Unable to verify transaction");
                }
                else
                {
                    var payment = paymentResult.data;

                    // ✅ Match expected vs actual amount from Flutterwave
                    bool amountMatches = Math.Round(amountExpected) == Math.Round(payment.amount);

                    var pay = new Payment
                    {
                        UserId = nominee.Id,
                        Amount = payment.amount,
                        Status = amountMatches
                        ? PaymentStatus.Successful.ToString()
                        : PaymentStatus.Incomplete.ToString(),
                        TransactionReference = cmd.ReferenceNumber,
                        AmountExpected = amountExpected,

                    };
                    await _unitOfWork.PaymentRepository.AddAsync(pay);
                    await _unitOfWork.Save(cancellationToken);


                    if (pay.Status == PaymentStatus.Successful.ToString())
                    {
                        var castVote = new Vote
                        {
                            NomineeId = nominee.Id,
                            AmountPaid = payment.amount,
                            VoterEmail = cmd.VoterEmail,
                            VoterName = cmd.VoterName,
                            Quantity = cmd.Quantity,
                            PaymentStatus = pay.Status,
                        };
                        await _unitOfWork.VoteRepository.AddAsync(castVote);
                        await _unitOfWork.Save(cancellationToken);
                        pay.VoteId = castVote.Id;
                        await _unitOfWork.PaymentRepository.Update(pay);
                        await _unitOfWork.Save(cancellationToken);

                        //Sum of votes
                        var votesQuery = _unitOfWork.VoteRepository.GetQueryable()
                        .Where(v => v.NomineeId == nominee.Id);

                        var totalVotes = await votesQuery.SumAsync(v => v.Quantity, cancellationToken);

                        var totalPeopleVoted = await votesQuery.CountAsync(cancellationToken);

                        //Send email to the voter
                        await _jobTestService.CastVote(cmd.VoterEmail, nominee.Account.FullName, cmd.Quantity.ToString(), cmd.CategoryName, cmd.ReferenceNumber);

                        //Send email to Nominee
                        await _jobTestService.NomineeCastVote(nominee.Account.FullName, nominee.Account.EmailAddress, totalVotes.ToString(), totalPeopleVoted.ToString());
                        return await Result<string>.SuccessAsync("vote cast successfully.");

                    }

                    else
                    {
                        return await Result<string>.FailureAsync("vote cannot be casted because the payment does not match");
                    }

                }
            }
            catch (Exception ex)
            {
                return await Result<string>.FailureAsync("error");
            }
            
        }
    }
}
