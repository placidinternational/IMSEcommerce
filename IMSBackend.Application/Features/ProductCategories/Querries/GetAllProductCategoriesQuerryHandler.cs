using IMSBackend.Application.Dtos.ProductCategoryDto;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.ProductCategories.Querries
{
    public class GetAllProductCategoriesQuerryHandler : IRequestHandler<GetAllProductCategoriesQuerry, Result<IEnumerable<GetProductCategoryResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllProductCategoriesQuerryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<IEnumerable<GetProductCategoryResponse>>> Handle(GetAllProductCategoriesQuerry request, CancellationToken cancellationToken)
        {
            var productCategory = await _unitOfWork.ProductCategoryRepository.GetAllAsync(cancellationToken);

            var returnedvalue = new List<GetProductCategoryResponse>();
            foreach (var category in productCategory) 
            {
                var data = new GetProductCategoryResponse
                {
                    Id = category.Id, 
                    Name = category.Name,
                    IsDeleted = category.IsDeleted,
                };
                returnedvalue.Add(data);
            }

            return await Result<IEnumerable<GetProductCategoryResponse>>.SuccessAsync(returnedvalue, "fetched successfully");
        }
    }
}
