using IMSBackend.Common;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.VendorCategoriesFeatures.Command.Create
{
    public class VendorCategoriesCommandHandler : IRequestHandler<VendorCategoriesCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public VendorCategoriesCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<string>> Handle(VendorCategoriesCommand request, CancellationToken cancellationToken)
        {
            var existingCategory = await _unitOfWork.VendorCategoryRepository.FindByFirstOrDefaultAsync(vc => vc.Name == request.Name, cancellationToken);

            if (existingCategory != null)
            {
                return await Result<string>.FailureAsync("A category with this exact name already exists.");
            }

            await _unitOfWork.VendorCategoryRepository.AddAsync(new Domain.Entities.Vendors.VendorCategory
            {
                Name = request.Name,
            });

            await _unitOfWork.Save(cancellationToken);
            return await Result<string>.SuccessAsync("Created successfully");
        }
    }
}
