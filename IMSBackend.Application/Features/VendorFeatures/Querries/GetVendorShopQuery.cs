using IMSBackend.Application.Dtos.VendorsDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.VendorFeatures.Querries
{
    public class GetVendorShopQuery : IRequest<PaginatedResult<GetVendorShopResponse>>
    {
        public Guid VendorId { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SearchParam { get; set; }
    }
}
