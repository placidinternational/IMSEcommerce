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
    public class GetEventDetailsQuery : IRequest<Result<EventDetailsDto>>
    {
        public Guid EventId { get; set; }
    }
}
