using GamingPeripheralsShop.BL.Interfaces;
using GamingPeripheralsShop.Models.Models.User;
using GamingPeripheralsShop.DL.Interfaces;
using GamingPeripheralsShop.Models.Models.Request;

namespace GamingPeripheralsShop.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Remove(int id)
        {
            _productRepository.Remove(id);
        }

        public List<Product> GetAllProductsByManufacturerId(int manufacturerId)
        {
            return _productRepository.GetAllProductsByManufacturerId(manufacturerId);
        }

        public int TestCalculation(int number)
        {
            var products = _productRepository.GetAll();
            return products.Count() + number;

        }
    }
}
