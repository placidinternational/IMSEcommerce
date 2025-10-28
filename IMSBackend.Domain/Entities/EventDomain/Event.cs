using IMSBackend.Common.Common;
using IMSBackend.Domain.Entities.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.EventDomain
{
    public class Event : BaseEntity
    {
        public Vendor Vendor { get; set; }
        public Guid VendorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public ICollection<TicketCategory> TicketCategories { get; set; }
    }
 }
