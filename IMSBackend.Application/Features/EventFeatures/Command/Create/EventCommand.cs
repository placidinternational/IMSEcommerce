using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.EventFeatures.Command.Create
{
    public class EventCommand : IRequest<Result<string>>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public int TotalCapacity { get; set; }
        public List<TicketCategoryRequest> TicketCategories { get; set; }
    }
    public class TicketCategoryRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }

    }
}
