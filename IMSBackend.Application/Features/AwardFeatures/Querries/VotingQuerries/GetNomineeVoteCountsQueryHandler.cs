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

        public GetNomineeVoteCountsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<int>> Handle(GetNomineeVoteCountsQuery request, CancellationToken cancellationToken)
        {
            var totalVoters = await _unitOfWork.VoteRepository.GetQueryable()
             .Where(v => v.NomineeId == request.NomineeId).CountAsync(cancellationToken);
            return await Result<int>.SuccessAsync(totalVoters);
        }
    }
}
