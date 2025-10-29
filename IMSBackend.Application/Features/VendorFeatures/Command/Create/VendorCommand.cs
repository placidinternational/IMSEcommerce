using IMSBackend.Common;
using IMSBackend.Common.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Features.VendorFeatures.Command.Create
{
    public class VendorCommand : IRequest<Result<string>>
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string logo { get; set; }
        public bool PassTaxToCustomer { get; set; }
        public VendorTypeEnum CategoryId { get; set; }
        public string Description { get; set; }
    }
}
