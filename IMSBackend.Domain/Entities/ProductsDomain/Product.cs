using IMSBackend.Common.Common;
using IMSBackend.Domain.Entities.Vendors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.Product
{
    public class Product : BaseEntity
    {
        public Vendor Vendor { get; set; }
        public Guid VendorId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Guid ProductCategoryId { get; set; }
    }
}
