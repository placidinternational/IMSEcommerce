using IMSBackend.Application.Dtos.CategoryDto;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using IMSBackend.Persistence.Migrations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.AwardFeatures.Querries.CategoryQuerries
{
    public class GetAllCategoriesQuerryHandler : IRequestHandler<GetAllCategoryQuerries, Result<List<CategoryResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllCategoriesQuerryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<List<CategoryResponse>>> Handle(GetAllCategoryQuerries request, CancellationToken cancellationToken)
        {
            var categories = await _unitOfWork.CategoryRepository.GetAllAsync(cancellationToken);

            var response = categories.Select(c => new CategoryResponse
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();

            return await Result<List<CategoryResponse>>.SuccessAsync(response, "Fetched successfully");
        }

    }
}
