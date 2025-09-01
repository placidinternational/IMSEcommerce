using IMSBackend.Application.Dtos.VotingDto;
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
    public class AdminVoteMetricsQuerryHandler : IRequestHandler<AdminVoteMetricsQuerry, Result<AdminVoteMetric>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminVoteMetricsQuerryHandler(IUnitOfWork unitOfWork)
        {
            
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<AdminVoteMetric>> Handle(AdminVoteMetricsQuerry request, CancellationToken cancellationToken)
        {

            var totalNominees = await _unitOfWork.NomineeRepository.GetQueryable().Where(x => x.IsActive).CountAsync();
            var totalVoters = await _unitOfWork.VoteRepository.GetQueryable().CountAsync();
            var totalCategories = await _unitOfWork.CategoryRepository.GetQueryable().CountAsync();
            var totalVotes = await _unitOfWork.VoteRepository.GetQueryable().SumAsync(v => v.Quantity);
            var revenue = await _unitOfWork.VoteRepository.GetQueryable().SumAsync(v => v.AmountPaid); 


            var metrics = new AdminVoteMetric
            {
                TotalVoters = totalVoters,
                TotalVotes = totalVotes,
                Revenue = revenue,
                TotalNominee = totalNominees
            };
            return await Result<AdminVoteMetric>.SuccessAsync(metrics);
        }
    }
}
