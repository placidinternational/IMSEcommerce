using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.EventDto
{
    public class TicketBookingDto
    {
        public Guid TicketCategoryId { get; set; }
        public int Quantity { get; set; }
    }
}
