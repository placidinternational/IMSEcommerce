using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.EventDomain
{
    public class TicketCategory : BaseEntity
 {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public Guid EventId { get; set; }
        public Event Event { get; set; }

    }
}
