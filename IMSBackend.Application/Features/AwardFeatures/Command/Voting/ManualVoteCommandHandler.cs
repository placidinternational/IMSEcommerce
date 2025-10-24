using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
using IMSBackend.Common.Interfaces;
using IMSBackend.Domain.Entities.Award;
using IMSBackend.Domain.Entities.Transactions;
using IMSBackend.Domain.Shared;
using IMSBackend.Persistence.Migrations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace IMSBackend.Application.Features.AwardFeatures.Command.Voting
{

   
   public record ManualVoteCommand(Guid NomineeId, int Quantity, decimal Amount, string VoterEmail, string VoterName, string CategoryName) : IRequest<Result<string>>;
    public class ManualVoteCommandHandler : IRequestHandler<ManualVoteCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJobTestService _jobTestService;
        private readonly IUserContext _userContext;

        public ManualVoteCommandHandler(IUnitOfWork unitOfWork, IJobTestService jobTestService, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
            _jobTestService = jobTestService;
            _userContext = userContext;
        }
        public async Task<Result<string>> Handle(ManualVoteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                
                var castVote = await _unitOfWork.VoteRepository.AddAsync(new Vote
                {
                    NomineeId = request.NomineeId,
                    AmountPaid = request.Amount,
                    VoterEmail = request.VoterEmail,
                    VoterName = request.VoterName,
                    Quantity = request.Quantity,
                    PaymentStatus = PaymentStatus.Manual.ToString(),
                    IsSuccessful = true,
                    CreatedBy = _userContext.UserId
                    
                });
                await _unitOfWork.VoteRepository.AddAsync(castVote);
                await _unitOfWork.Save(cancellationToken);

                if (castVote != null)
                {
                    var nominee = await _unitOfWork.NomineeRepository.GetQueryable().Include(x => x.Account).Where(x => x.Id == request.NomineeId).FirstOrDefaultAsync();
                    //Sum of votes
                    var votesQuery = _unitOfWork.VoteRepository.GetQueryable()
                    .Where(v => v.NomineeId == nominee.Id);

                    var totalVotes = await votesQuery.SumAsync(v => v.Quantity, cancellationToken);

                    var totalPeopleVoted = await votesQuery.CountAsync(cancellationToken);

                    //Send email to the voter
                    await _jobTestService.CastVote(request.VoterEmail, nominee.Account.FullName, request.Quantity.ToString(), request.CategoryName, "Manual");

                    //Send email to Nominee
                    await _jobTestService.NomineeCastVote(nominee.Account.FullName, nominee.Account.EmailAddress, totalVotes.ToString(), totalPeopleVoted.ToString());
                    return await Result<string>.SuccessAsync("vote casted successfully");
                }
                return await Result<string>.FailureAsync("failed to create");

            }
            catch (Exception ex) 
            {
                return await Result<string>.FailureAsync("error");
            }
        }
    }
}
