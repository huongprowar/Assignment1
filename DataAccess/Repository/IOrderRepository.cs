using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        Order GetOrder(int id);
        void Update(Order order);
        IEnumerable<Order> GetOrders();
    }
}
