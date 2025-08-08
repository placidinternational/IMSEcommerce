using IMSBackend.Application.Dtos.VotingDto;
using IMSBackend.Common;
using IMSBackend.Common.Enums;
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
    public class VoteMetricQueryHandler : IRequestHandler<VoteMetricQuery, Result<VotingMetircDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public VoteMetricQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<VotingMetircDto>> Handle(VoteMetricQuery request, CancellationToken cancellationToken)
        {
            var totalNominees =  await _unitOfWork.NomineeRepository.GetQueryable().Where(x=>x.IsActive).CountAsync();
            var voters =await  _unitOfWork.VoteRepository.GetQueryable().CountAsync();
            var totalCategories =await  _unitOfWork.CategoryRepository.GetQueryable().CountAsync();

            var result = new VotingMetircDto
            {
                TotalNominees = totalNominees,
                TotalVoters = voters,
                TotalCategories = totalCategories
            };

            return await Result<VotingMetircDto>.SuccessAsync(result, "Fetched successfully");
        }
    }
}
