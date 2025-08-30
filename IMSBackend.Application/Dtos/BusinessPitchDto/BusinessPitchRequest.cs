using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.BusinessPitchDto
{
    public class BusinessPitchRequest
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BusinessName { get; set; }
        public string Picture { get; set; }
        public string Logo { get; set; }
        public string? BusinessDescription { get; set; }
        public string BusinessLogo { get; set; }
        public string OwnersPicture { get; set; }
        public string ReferenceNumber { get; set; }

    }

    public class PitchPriceDto
    {
        public decimal Price { get; set; }
    }
}
