using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T entity);        
        void Delete(T entity);        
    }
}
