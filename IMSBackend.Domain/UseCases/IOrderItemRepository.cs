using IMSBackend.Domain.Common;
using IMSBackend.Domain.Entities.OrderDomain;

namespace IMSBackend.Domain.UseCases
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {
    }
}
