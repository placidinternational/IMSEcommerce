using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.Vendors
{
    public class BankDetails : BaseEntity
    {
        public Vendor Vendor { get; set; }
        public Guid VendorId { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string NameOnAccount { get; set; }
    }
}
