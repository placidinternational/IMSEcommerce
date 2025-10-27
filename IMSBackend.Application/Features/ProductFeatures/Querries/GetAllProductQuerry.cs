using IMSBackend.Application.Dtos.ProductDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.ProductFeatures.Querries
{
    public class GetAllProductQuerry : IRequest<PaginatedResult<GetProductResponse>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SearchParam { get; set; }
    }
}
