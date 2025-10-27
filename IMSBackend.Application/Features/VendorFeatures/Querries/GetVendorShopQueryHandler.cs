using IMSBackend.Application.Dtos.ProductDto;
using IMSBackend.Application.Dtos.VendorsDto;
using IMSBackend.Common;
using IMSBackend.Common.Extensions;
using IMSBackend.Common.Helpers;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.VendorFeatures.Querries
{
    public class GetVendorShopQueryHandler : IRequestHandler<GetVendorShopQuery, PaginatedResult<GetVendorShopResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetVendorShopQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<GetVendorShopResponse>> Handle(GetVendorShopQuery request, CancellationToken cancellationToken)
        {
            try
            {
               
                var query = _unitOfWork.ProductRepository.GetQueryable().Where(x=>x.VendorId == request.VendorId);

                // Apply search filter
                if (!string.IsNullOrEmpty(request.SearchParam))
                {
                    query = query.Where(a =>
                        a.Name.Contains(request.SearchParam) ||
                        a.Description.Contains(request.SearchParam));
                }
                var product = await query.Select(a => new GetVendorShopResponse
                {
                    ProductName = a.Name,
                    CostPrice = a.CostPrice,
                    DiscountPrice = a.DiscountPrice,
                    Rating = "",
                    PercentageOff = CommonHelper.CalculateDiscountPercentage(a.CostPrice, a.DiscountPrice),
                    Image = a.Image,

                }).ToPaginatedListAsync(request.PageNumber, request.PageSize, cancellationToken);
                return product;
            }

            catch (Exception ex)
            {
                return new PaginatedResult<GetVendorShopResponse>
                {
                    PageSize = request.PageSize,
                    TotalCount = 0,
                    Succeeded = false,
                    Data = new List<GetVendorShopResponse>()
                };
            }

        }
    }
}
