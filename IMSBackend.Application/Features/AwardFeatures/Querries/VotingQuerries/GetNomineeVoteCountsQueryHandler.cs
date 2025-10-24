using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.NewFolder;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries
{
    public class GetNomineeVoteCountsQueryHandler : IRequestHandler<GetNomineeVoteCountsQuery, Result<NomineeVoteCounts>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserContext _userContext;

        public GetNomineeVoteCountsQueryHandler(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
            _userContext = userContext;
        }
        public async Task<Result<NomineeVoteCounts>> Handle(GetNomineeVoteCountsQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.NomineeRepository.GetSingleByExpression(x => x.AccountId == _userContext.UserId, cancellationToken);

            var query =  _unitOfWork.VoteRepository.GetQueryable()
             .Where(v => v.NomineeId == user.Id).AsQueryable();

            var TotalVoters = await query.CountAsync(cancellationToken);
            var TotalVotes = await query.SumAsync(v=>v.Quantity);

            var data = new NomineeVoteCounts
            {
               TotalVoters =  TotalVoters,
               TotalVotes =  TotalVotes
            };

            return await Result<NomineeVoteCounts>.SuccessAsync(data, "Data fetched successfully");
        }
    }
   
}
