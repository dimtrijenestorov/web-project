using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Entities
{
    public class Repository<T, V> : IRepository<T, V> where T : class
    {
        protected readonly DbContext _dbContext;
        private DbSet<T> _entities;

        public Repository(DbContext context)
        {
            _dbContext = context;
            _entities = _dbContext.Set<T>();
        }

        public T GetById(V id)
        {
            T tEntity = null;
            tEntity = _entities.Find(id);
            return tEntity;
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> tEntityEnumerable = new List<T>();
            tEntityEnumerable = _entities.Where(predicate).ToList();
            return tEntityEnumerable;
        }

        public T Add(T entity)
        {
            _entities.Add(entity);
            return entity;
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }
    }
}
