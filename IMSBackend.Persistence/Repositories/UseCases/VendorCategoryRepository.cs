using IMSBackend.Domain.Entities.Vendors;
using IMSBackend.Persistence.Context;
using IMSBackend.Persistence.IRepositories.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class VendorCategoryRepository : Repository<VendorCategory>, IVendorCategoryRepository
    {
        public VendorCategoryRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}
