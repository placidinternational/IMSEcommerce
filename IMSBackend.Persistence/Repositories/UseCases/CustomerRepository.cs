using IMSBackend.Domain.Entities.CustomerDomain;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}
