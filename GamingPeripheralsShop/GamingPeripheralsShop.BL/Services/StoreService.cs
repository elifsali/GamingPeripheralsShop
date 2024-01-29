using GamingPeripheralsShop.BL.Interfaces;
using GamingPeripheralsShop.Models.Models.Request;
using GamingPeripheralsShop.Models.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingPeripheralsShop.BL.Services
{
    public class StoreService : IStoreService
    {
        private readonly IManufacturerService _manufacturerService;
        private readonly IProductService _productService;

        public StoreService(IManufacturerService manufacturerService, IProductService productService)
        {
            _manufacturerService = manufacturerService;
            _productService = productService;
        }

        public GetProductsByManufacturerResponse? GetProductsByManufacturer(GetProductsByManufacturerRequest request) 
        { 
            var products = _productService.GetAllProductsByManufacturerId(request.ManufacturerId);

            if (products != null && products.Count > 0)
            {
                var response = new GetProductsByManufacturerResponse
                {
                    Manufacturer = _manufacturerService.GetById(request.ManufacturerId),
                    Products = products
                    .Where(product =>
                        (product.Price >= request.MinPrice) &&
                        (product.Price <= request.MaxPrice))
                    .ToList()
                };
                return response;
            }
            return null;
        }
    };
}
