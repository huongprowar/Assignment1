using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetail(int orderId, int productId)
        {
            List<OrderDetail> resultList = new List<OrderDetail>();            
            if (orderId != null)
            {
                resultList = FstoreContext.Instance.OrderDetails.Where(x => x.OrderId== orderId).ToList();
            }
            return resultList;
        }
    }
}
