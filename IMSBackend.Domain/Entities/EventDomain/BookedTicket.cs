using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.EventDomain
{
    public class BookedTicket : BaseEntity
    {
        public Guid OrderId { get; set; } 
        public Guid CustomerId { get; set; }
        public Guid VendorId { get; set; } 

        // Ticket Design / Receipt fields
        public string TicketNumber { get; set; } 
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        // Event/Category details stored directly (denormalized)
        public Guid TicketCategoryId { get; set; }
        public string TicketCategoryName { get; set; } // e.g., "VIP"
        public string EventTitle { get; set; }
        public string VenueName { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }

        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
