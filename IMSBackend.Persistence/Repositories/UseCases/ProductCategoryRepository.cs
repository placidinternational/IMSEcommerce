using IMSBackend.Domain.Entities.Product;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}
