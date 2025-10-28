using IMSBackend.Application.Dtos.EventDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.EventFeatures.Querries
{
    public class GetVendorEventsDashboardQuery : IRequest<Result<IEnumerable<EventDashboardItemDto>>>
    {
        public int PageNumber { get; set; } = 10;
        public int PageSize { get; set; } = 1;
        public string SearchParam { get; set; } = null;
    }
}
