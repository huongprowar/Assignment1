using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        FstoreContext _context = FstoreContext.Instance;        
        public T Add(T entity)
        {
            try
            {
                FstoreContext context = new FstoreContext();
                context.Entry(entity).State = EntityState.Added;
                context.Add(entity);
                context.SaveChanges();
                return entity;
            }catch(Exception ex)
            {
                throw new Exception(typeof(T)+" is already exist");
            }
        }

        public void Delete(T entity)
        {
            try
            {

            _context.Entry(entity).State = EntityState.Deleted;
            _context.Remove(entity);
            _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(typeof(T) + " not found");
            }
        }                

    }
}
