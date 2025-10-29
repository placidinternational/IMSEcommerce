using IMSBackend.Application.Dtos.EventDto;
using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.EventFeatures.Command.Update
{
    public class UpdateEventCommand : IRequest<Result<string>>
    {
        public Guid EventId { get; set; }
        public Guid VendorId { get; set; } // For ownership/security check
        public DateTime EventDate { get; set; }
        public string EventTime { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public List<TicketCategoryEditDto> TicketCategories { get; set; } = new List<TicketCategoryEditDto>();
    }

}
