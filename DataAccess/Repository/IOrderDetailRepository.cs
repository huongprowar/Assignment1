using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetail(int orderId, int memberId);

    }
}
