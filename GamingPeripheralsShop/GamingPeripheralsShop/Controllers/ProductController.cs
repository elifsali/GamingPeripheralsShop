using GamingPeripheralsShop.BL.Interfaces;
using GamingPeripheralsShop.Models.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingPeripheralsShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProductById")]
        public Product GetProductById(int id)
        {
            return _productService.GetById(id);
        }

        [HttpGet("GetAll")]
        public List<Product> GetAllProducts() 
        {
            return _productService.GetAll();
        }

        [HttpPost("Add")]
        public void Add([FromBody] Product product)
        {
            if (product == null) return;
            _productService.Add(product);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _productService.Remove(id);
        }

    }
}
