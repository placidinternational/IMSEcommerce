using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Application.Dtos.ProductCategoryDto
{
    public class GetProductCategoryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string  Image{ get; set; }
        public bool IsDeleted { get; set; }

    }
}
