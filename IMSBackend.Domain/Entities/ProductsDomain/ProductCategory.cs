using IMSBackend.Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.Entities.Product
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
