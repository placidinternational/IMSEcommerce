using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.EventDto
{
    public class GetAllEventsDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Logo { get; set; }
        public string Venue { get; set; }
        public decimal price { get; set; }
        public string Address { get; set; } 
        public DateTime EventDate { get; set; }
    }
}
