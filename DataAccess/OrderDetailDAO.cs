using BusinessObject.Models;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        FstoreContext _context = FstoreContext.Instance;
        public void Add(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }
        public void Update(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
            _context.SaveChanges();
        }
        public void Delete(OrderDetail orderDetail)
        {
            _context.OrderDetails.Remove(orderDetail);
            _context.SaveChanges();
        }        
    }
}
