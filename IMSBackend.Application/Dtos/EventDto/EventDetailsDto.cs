using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.EventDto
{
    public class EventDetailsDto
    {
        public Guid EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public bool PassTaxToCustomer { get; set; } // New field from Vendor table
        public int TotalCategoriesCount { get; set; }
        public CompanyDetails CompanyDetails { get; set; }
        public List<TicketCategoryDetailsDto> TicketCategories { get; set; } = new List<TicketCategoryDetailsDto>();
    }
    public class CompanyDetails
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
