using IMSBackend.Application.Contracts;
using IMSBackend.Application.Dtos.ProductDto;
using IMSBackend.Common;
using IMSBackend.Common.Extensions;
using IMSBackend.Domain.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IMSBackend.Application.Features.ProductFeatures.Querries
{
    public class GetAllProductQuerryHandler : IRequestHandler<GetAllProductQuerry, PaginatedResult<GetProductResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserContext _userContext;

        public GetAllProductQuerryHandler(IUnitOfWork unitOfWork, IUserContext userContext)
        {
            _unitOfWork = unitOfWork;
            _userContext = userContext;
        }
        public async Task<PaginatedResult<GetProductResponse>> Handle(GetAllProductQuerry request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _unitOfWork.VendorsRepository.GetSingleByExpression(x => x.AccountId == _userContext.UserId, cancellationToken);
              
                var query =  _unitOfWork.ProductRepository.GetQueryable().Include(x=>x.ProductCategory).Where(a=> a.VendorId == user.Id);
               
                // Apply search filter
                if (!string.IsNullOrEmpty(request.SearchParam))
                {
                    query = query.Where(a =>
                        a.Name.Contains(request.SearchParam) ||
                        a.Description.Contains(request.SearchParam));
                }
                var product =await query.Select( a=>new GetProductResponse
                {
                    ProductId = a.Id,
                    Price = a.CostPrice,
                    Name = a.Name,
                    Description = a.Description,
                    Quantity = a.Quantity,
                    Category =a.ProductCategory.Name,
                    Image = a.Image,

                }).ToPaginatedListAsync(request.PageNumber, request.PageSize, cancellationToken);
                return product;
            }

            catch (Exception ex) 
            {
                return new PaginatedResult<GetProductResponse>
                {
                    PageSize = request.PageSize,
                    TotalCount = 0,
                    Succeeded = false,
                    Data = new List<GetProductResponse>()
                };
            }

           
        }
    }
}
