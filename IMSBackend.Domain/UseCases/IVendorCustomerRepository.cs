using IMSBackend.Domain.Common;
using IMSBackend.Domain.Entities.CustomerDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Domain.UseCases
{
    public interface IVendorCustomerRepository :IRepository<VendorCustomer>
    {
    }
}
