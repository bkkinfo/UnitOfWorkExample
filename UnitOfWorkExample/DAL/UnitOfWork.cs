using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkExample.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProductRepository _products;
        public IProductRepository products { get; private set; }
        private RepoContext _dbContext;
        public UnitOfWork(RepoContext dbContext)
        {
            _dbContext = dbContext;
            products = new ProductRepository(dbContext);
        }
     
        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
