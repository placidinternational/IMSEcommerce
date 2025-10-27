using IMSBackend.Common.Common;
using IMSBackend.Domain.Entities.Vendors;

namespace IMSBackend.Domain.Entities.CustomerDomain
{
    public class VendorCustomer : BaseEntity
    {
        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime LastPurchaseDate { get; set; } = DateTime.UtcNow;
    }
}