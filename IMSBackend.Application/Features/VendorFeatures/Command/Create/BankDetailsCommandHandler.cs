using IMSBackend.Common;
using IMSBackend.Domain.Entities.Vendors;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.VendorFeatures.Command.Create
{
    public class BankDetailsCommandHandler : IRequestHandler<BankDetailsCommand, Result<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public BankDetailsCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<string>> Handle(BankDetailsCommand request, CancellationToken cancellationToken)
        {
           var vendor = await _unitOfWork.VendorCategoryRepository.GetByIdAsync(request.VendorId, cancellationToken);
            if (vendor == null) 
            { 
                return await Result<string>.FailureAsync("Vendor not found");
            }
            var vendorBankDetails = new BankDetails
            {
                VendorId = request.VendorId,
                BankName = request.BankName,
                AccountNumber = request.AccountNumber,
                NameOnAccount = request.AccountName
            };
            var data =  await _unitOfWork.BankDetailsRepository.AddAsync(vendorBankDetails);
            await _unitOfWork.Save(cancellationToken);
           
            if (data.Id != Guid.Empty)
            {
                return await Result<string>.SuccessAsync("Bank details added successfully");
            }
            else
            {
                return await Result<string>.FailureAsync("Failed to add bank details");
            }
        }
    }
}
