using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.EventDto
{
    public class TicketCategoryDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal TaxRate { get; set; } 

        public decimal FinalPricePerTicket { get; set; }
        public int Capacity { get; set; }
        public int TicketsSold { get; set; } 
        public int SeatsLeft => Capacity - TicketsSold;
    }
}
