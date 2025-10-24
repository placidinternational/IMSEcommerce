using IMSBackend.Application.Dtos.NewFolder;
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
    public class AdminGetNomineeVoteCountsQuery : IRequest<Result<NomineeVoteCounts>>
    {
        public Guid Id { get; set; }
    }

    public class AdminGetNomineeVoteCountsQueryHandler : IRequestHandler<AdminGetNomineeVoteCountsQuery, Result<NomineeVoteCounts>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminGetNomineeVoteCountsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<NomineeVoteCounts>> Handle(AdminGetNomineeVoteCountsQuery request, CancellationToken cancellationToken)
        {

            var query = _unitOfWork.VoteRepository.GetQueryable()
             .Where(v => v.NomineeId == request.Id).AsQueryable();

            var TotalVoters = await query.CountAsync(cancellationToken);
            var TotalVotes = await query.SumAsync(v => v.Quantity);

            var data = new NomineeVoteCounts
            {
                TotalVoters = TotalVoters,
                TotalVotes = TotalVotes
            };
            return await Result<NomineeVoteCounts>.SuccessAsync(data, "Data fetched successfully");
        }
    }
}
