using GamingPeripheralsShop.DL.Interfaces;
using GamingPeripheralsShop.DL.MemoryDb;
using GamingPeripheralsShop.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GamingPeripheralsShop.DL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll()
        {
            return InMemoryDb.ProductData;
        }
        public Product GetById(int id)
        {
            return InMemoryDb.ProductData.First(a => a.Id == id);
        }
        public void Add(Product product)
        {
            InMemoryDb.ProductData.Add(product);
        }
        public void Remove(int id)
        {
            var product = GetById(id);
            InMemoryDb.ProductData.Remove(product);
        }

        public List<Product> GetAllProductsByManufacturerId(int id)
        {
            var result = InMemoryDb.ProductData.Where(b => b.ManufacturerId == id).ToList();
            return result;
        }
    }
}
