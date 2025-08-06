using IMSBackend.Application.Dtos.CategoryDto;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.CategoryQuerries
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, Result<CategoryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCategoryByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<CategoryResponse>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {

            var query = await _unitOfWork.CategoryRepository.GetByIdAsync(request.Id, cancellationToken);

            if (query is null)
            {
                return await Result<CategoryResponse>.FailureAsync("category not found");
            }

            var response = new CategoryResponse
            {
                Id = query.Id,
                Name = query.Name
            }; 
            return await Result<CategoryResponse>.SuccessAsync(response, "Fetched successfully");
        }

    }
}

