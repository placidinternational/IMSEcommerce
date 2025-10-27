using IMSBackend.Common.Common;
using IMSBackend.Domain.Entities.Product;
using IMSBackend.Domain.Entities.Vendors;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMSBackend.Domain.Entities.OrderDomain
{
    public class OrderItem : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid ProductId { get; set; }
        public IMSBackend.Domain.Entities.Product.Product Product { get; set; }
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int Quantity { get; set; }
    }
}