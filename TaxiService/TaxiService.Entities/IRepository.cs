using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities
{
    public interface IRepository<T, V> where T : class
    {
        T GetById(V id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        T Add(T entity);

        void Remove(T entity);
    }
}
