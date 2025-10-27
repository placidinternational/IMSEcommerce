using IMSBackend.Common.Common;
using IMSBackend.Domain.Entities.OrderDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.CustomerDomain
{
    public class Customer : BaseEntity
    {
        public string EmaulAddress { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<VendorCustomer> VendorRelationships { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
