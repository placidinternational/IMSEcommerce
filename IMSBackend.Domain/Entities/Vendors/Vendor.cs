using IMSBackend.Common.Common;
using IMSBackend.Domain.Entities.AccountDomain;
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
        public Country Country { get; set; }
        public Guid? CountryId { get; set; }
        public State State { get; set; }
        public Guid? StateId { get; set; }
        public VendorCategory Category { get; set; }
        public Guid? CategoryId { get; set; }
        public string Description { get; set; }
        public bool IsFeatured { get; set; } = false;
        public bool IsVerified { get; set; } = false;
        public ICollection<BankDetails> BankDetails { get; set; }

    }
}
