using IMSBackend.Application.Contracts;
using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.ProductFeatures.Command.Create
{
    public class ProductCommandHandler : IRequestHandler<ProductCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserContext _userContext;

        public ProductCommandHandler(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
            _userContext = userContext;
        }
        public async Task<Result<string>> Handle(ProductCommand request, CancellationToken cancellationToken)
        {

            var vendor =await _unitOfWork.VendorsRepository.GetSingleByExpression(x => x.AccountId == _userContext.UserId, cancellationToken);
            if (vendor == null) 
            {
                return await Result<string>.SuccessAsync("vendor not found");
            }

            var existingCategory = await _unitOfWork.ProductRepository.FindByFirstOrDefaultAsync(vc => vc.Name == request.Name  && vc.VendorId ==vendor.Id, cancellationToken);

            if (existingCategory != null)
            {
                return await Result<string>.FailureAsync("A product with this exact name already exist for this vendot");
            }

            await _unitOfWork.ProductRepository.AddAsync(new Domain.Entities.Product.Product
            {
                Name = request.Name,
                CostPrice = request.Price,
                DiscountPrice = request.DiscountPrice,
                ProductCategoryId  = request.ProductCategoryId,
                Description = request.Description,
                Image = request.Image,
                Quantity = request.Quantity,
                VendorId = vendor.Id,
            });
            await _unitOfWork.Save(cancellationToken);
            return await Result<string>.SuccessAsync("Product saved successfully");
        }
    }
}
