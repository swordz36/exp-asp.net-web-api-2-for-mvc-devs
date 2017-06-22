using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductsController : ApiController
    {
        private IRepository Repository { get; set; }

        public ProductsController()
        {
            Repository = new ProductRepository();
        }

        public IEnumerable<Product> GetProducts()
        {
            return Repository.Products;
        }

        public Product GetProduct(int id)
        {
            return Repository.Products.FirstOrDefault(p => p.Id == id);
        }

        public async Task PostProduct(Product product)
        {
            await Repository.SaveProductAsync(product);
        }

        public async Task DeleteProduct(int id)
        {
            await Repository.DeleteProductAsync(id);
        }


    }
}
