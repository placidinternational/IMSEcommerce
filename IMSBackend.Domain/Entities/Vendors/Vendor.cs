using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.Vendors
{
    public class Vendor : BaseEntity
    {
        public string EmailAddress { get; set; }
        public string Fullname { get; set; }
        public Guid AccountId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Logo { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public ICollection<BankDetails> BankDetails { get; set; }

    }
}
