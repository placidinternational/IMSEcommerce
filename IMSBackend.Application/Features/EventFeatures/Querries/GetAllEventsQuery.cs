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
    public class GetAllEventsQuery : IRequest<PaginatedResult<GetAllEventsDto>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SearchParam { get; set; }
    }
     
}
