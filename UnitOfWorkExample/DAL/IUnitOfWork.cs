using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkExample.DAL
{
    interface IUnitOfWork : IDisposable
    {
        IProductRepository products { get; }

        int Complete();
    }
}
