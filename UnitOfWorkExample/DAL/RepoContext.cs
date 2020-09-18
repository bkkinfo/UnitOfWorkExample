using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkExample.Models;

namespace UnitOfWorkExample.DAL
{
    public class RepoContext : DbContext
    {
        public RepoContext(){
        }
        public RepoContext(DbContextOptions<RepoContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
