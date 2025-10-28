using IMSBackend.Domain.Entities.CustomerDomain;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class VendorCustomerRepository : Repository<VendorCustomer>, IVendorCustomerRepository
    {
        public VendorCustomerRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}
