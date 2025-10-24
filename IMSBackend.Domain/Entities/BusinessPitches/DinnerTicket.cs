using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.BusinessPitches
{
    public class DinnerTicket :BaseEntity
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string TicketType { get; set; }
        public string TicketCode { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
