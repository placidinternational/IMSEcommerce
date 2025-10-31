using IMSBackend.Application.Dtos.EventDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.CheckoutFeatures
{
    public class ProcessEventOrderCommand : IRequest<Result<string>>
    {
        public List<TicketBookingDto> TicketBookingDto { get; set; }
        public string ReferenceNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
    }
}
