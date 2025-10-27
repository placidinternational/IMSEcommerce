using IMSBackend.Application.Dtos.VendorsDto;
using IMSBackend.Common;
using IMSBackend.Common.Extensions;
using IMSBackend.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.VendorFeatures.Querries
{
    public class GetAllFeaturedVendorsQueryHandler : IRequestHandler<GetAllFeaturedVendorsQuery, PaginatedResult<GetAllFeaturedVendorsResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllFeaturedVendorsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<GetAllFeaturedVendorsResponse>> Handle(GetAllFeaturedVendorsQuery request, CancellationToken cancellationToken)
        {
            var query = _unitOfWork.VendorsRepository.GetQueryable().Where(x=>x.IsFeatured && x.IsVerified);

            var productsQuery = _unitOfWork.ProductRepository.GetQueryable();

            var vendors = await query.Select(a => new GetAllFeaturedVendorsResponse
            {
                Id = a.Id,
                Name= a.CompanyName,
                Address = a.Address,
                Image = a.Logo,
                Rating = "4.5",
                IsFeaured = a.IsFeatured,
                IsVerified = a.IsVerified,
                NumberOfProducts = productsQuery.Count(p=>p.VendorId == a.Id),
            }).ToPaginatedListAsync(request.PageNumber,request.PageSize, cancellationToken);

            return vendors;
           
        }
    }
}
