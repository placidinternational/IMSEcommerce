using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries
{
    public class GetNomineeVoteCountsQueryHandler : IRequestHandler<GetNomineeVoteCountsQuery, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserContext _userContext;

        public GetNomineeVoteCountsQueryHandler(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
            _userContext = userContext;
        }
        public async Task<Result<int>> Handle(GetNomineeVoteCountsQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.NomineeRepository.GetSingleByExpression(x => x.AccountId == _userContext.UserId, cancellationToken);

            var totalVoters = await _unitOfWork.VoteRepository.GetQueryable()
             .Where(v => v.NomineeId == user.Id).CountAsync(cancellationToken);
            return await Result<int>.SuccessAsync(totalVoters, "Data fetched successfully");
        }
    }
}
