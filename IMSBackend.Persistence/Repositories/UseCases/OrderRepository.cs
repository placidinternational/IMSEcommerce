using IMSBackend.Domain.Entities.OrderDomain;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}
