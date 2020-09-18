using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkExample.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly RepoContext dbContext;

        public Repository(RepoContext _dbContext) {
            dbContext = _dbContext;
        }
        public void add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            //throw new NotImplementedException();
        }

        public TEntity Get(int Id)
        {
            return dbContext.Set<TEntity>().Find(Id);

        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public void Remove(int Id)
        {
            TEntity entity = dbContext.Set<TEntity>().Find(Id);
            dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
