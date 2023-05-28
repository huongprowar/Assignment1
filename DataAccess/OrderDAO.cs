using BusinessObject.Models;
using DataAccess.Repository;

namespace DataAccess
{
    public class OrderDAO : BaseRepository<Order>
    {
        //FstoreContext _context = FstoreContext.Instance;
        //public void Add(Order order)
        //{
        //    _context.Orders.Add(order);
        //    _context.SaveChanges();
        //}
        //public void Update(Order order)
        //{
        //    _context.Orders.Update(order);
        //    _context.SaveChanges();
        //}
        //public void Delete(Order order)
        //{
        //    _context.Orders.Remove(order);
        //    _context.SaveChanges();
        //}
        //public void GetByID(int id) => _context.Orders.FirstOrDefault(x => x.OrderId == id);
    }
}
