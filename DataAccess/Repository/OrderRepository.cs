using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public Order GetOrder(int id)
        {
            return FstoreContext.Instance.Orders.FirstOrDefault(x => x.OrderId == id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return FstoreContext.Instance.Orders.ToList();
        }

        public void Update(Order order)
        {
            Order _order = FstoreContext.Instance.Orders.FirstOrDefault(x => x.OrderId == order.OrderId);
            _order.Freight = order.Freight;
            _order.OrderId = order.OrderId;
            _order.OrderDate = order.OrderDate;
            _order.RequiredDate= order.RequiredDate;
            _order.ShippedDate  = order.ShippedDate;
            _order.Member = FstoreContext.Instance.Members.FirstOrDefault(x => x.MemberId==order.MemberId);
            FstoreContext.Instance.Orders.Update(_order);
            FstoreContext.Instance.SaveChanges();
        }
    }
}
