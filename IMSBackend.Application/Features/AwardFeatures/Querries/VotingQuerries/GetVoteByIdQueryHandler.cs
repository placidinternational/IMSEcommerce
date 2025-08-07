using IMSBackend.Application.Dtos.NewFolder;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using IMSBackend.Persistence.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.VotingQuerries
{
    public class GetVoteByIdQueryHandler : IRequestHandler<GetVoteByIdQuery, Result<VotingResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetVoteByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<VotingResponse>> Handle(GetVoteByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var vote = _unitOfWork.VoteRepository.GetQueryable().Include(x => x.Nominee)
                        .ThenInclude(a => a.Account).Where(x => x.Id == request.Id).FirstOrDefault();
                
               
                    var category = await _unitOfWork.CategoryRepository.GetByIdAsync(vote.Nominee.CategoryId, cancellationToken);

                var result = new VotingResponse
                    {
                        AmountPaid = vote.AmountPaid,
                        DateVoted = vote.DateCreated,
                        Nominee = vote.Nominee.Account.FullName,
                        Qunatity = vote.Quantity,
                        Category = category.Name
                    };
                

                return await Result<VotingResponse>.SuccessAsync(result, "Data fetched successfully");
                
            }
            catch (Exception)
            {
                return await Result<VotingResponse>.FailureAsync("error");
            }
        }
    }
}
