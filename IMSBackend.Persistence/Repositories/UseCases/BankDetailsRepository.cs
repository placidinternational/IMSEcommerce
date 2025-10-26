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
    public class BankDetailsRepository : Repository<BankDetails>, IBankDetailsRepository
    {
        public BankDetailsRepository(IMSEcommerceContext _DbContext) : base(_DbContext)
        {
        }
    }
}
