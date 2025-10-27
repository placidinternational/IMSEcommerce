using IMSBackend.Domain.Entities.OrderDomain;
using IMSBackend.Domain.UseCases;
using IMSBackend.Persistence.Context;

namespace IMSBackend.Persistence.Repositories.UseCases
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(IMSBackendContext _DbContext) : base(_DbContext)
        {
        }
    }
}
