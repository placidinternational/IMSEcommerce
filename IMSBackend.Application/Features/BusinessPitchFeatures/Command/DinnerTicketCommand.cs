using IMSBackend.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.BusinessPitchFeatures.Command
{
    public class DinnerTicketCommand : IRequest<Result<string>>
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string TicketType { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public string ReferenceNumber { get; set; }
    }
}
