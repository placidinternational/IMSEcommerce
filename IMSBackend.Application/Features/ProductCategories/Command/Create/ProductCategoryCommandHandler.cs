using IMSBackend.Common;
using IMSBackend.Domain.Entities.Product;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.ProductCategories.Command.Create
{
    public class ProductCategoryCommandHandler : IRequestHandler<ProductCategoryCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<string>> Handle(ProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var existingCategory = await _unitOfWork.ProductCategoryRepository.FindByFirstOrDefaultAsync(vc => vc.Name == request.Name, cancellationToken);

            if (existingCategory != null)
            {
                return await Result<string>.FailureAsync("A category with this exact name already exists.");
            }

            await _unitOfWork.ProductCategoryRepository.AddAsync(new ProductCategory
            {
                Name = request.Name,
                Image = request.Image,
            });

            await _unitOfWork.Save(cancellationToken);
            return await Result<string>.SuccessAsync("Created successfully");
        }
    }
}

