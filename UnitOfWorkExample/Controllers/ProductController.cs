using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkExample.DAL;
using UnitOfWorkExample.Models;

namespace UnitOfWorkExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IUnitOfWork unitofwork = new UnitOfWork(new RepoContext());
        [Route("getproducts")]
        [HttpGet]
        public IEnumerable<Product> GetProducts() {
            return unitofwork.products.GetAll();
        }
        [Route("getproducts/{Id}")]
        [HttpGet]
        public Product GetProduct(int id) {
            return unitofwork.products.Get(id);
        }
        [Route("addproduct")]
        [HttpPost]
        public void AddProduct(Product product) {
            unitofwork.products.add(product);
            unitofwork.Complete();
        }
        [Route("deleteproduct")]
        [HttpDelete]
        public void DeleteProduct(int id) {
            unitofwork.products.Remove(id);
            unitofwork.Complete();
        }
    }
}
