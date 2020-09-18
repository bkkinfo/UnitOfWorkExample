using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkExample.Models;

namespace UnitOfWorkExample.DAL
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetToProducts();
    }
}
