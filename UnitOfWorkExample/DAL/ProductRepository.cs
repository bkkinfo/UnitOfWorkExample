using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using UnitOfWorkExample.Models;

namespace UnitOfWorkExample.DAL
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(RepoContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Product> GetToProducts()
        {
            return dbContext.Products.Take(2);
        }
        public RepoContext RepoContext {
            get{ return dbContext as RepoContext; }
        }
    }
}
