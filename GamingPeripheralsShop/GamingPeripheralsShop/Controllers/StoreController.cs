using GamingPeripheralsShop.BL.Interfaces;
using GamingPeripheralsShop.Models.Models.Request;
using GamingPeripheralsShop.Models.Models.Response;
using GamingPeripheralsShop.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamingPeripheralsShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpPost("GetProductsByManufacturer")]
        public GetProductsByManufacturerResponse? GetProductsByManufacturer(GetProductsByManufacturerRequest request)
        {
            if (request == null) return null;
            return _storeService.GetProductsByManufacturer(request);
        }

        [HttpPost("TestEndpoint")]
        public string GetTestEndpoint([FromBody] GetProductsByManufacturerRequest request)
        {
            var validator = new GetProductsByManufacturerRequestValidator();

            var result = validator.Validate(request);
            if (result.IsValid)
            {
                return "Test Pass";
            }
            return "Test Not Pass";
        }


    }
}
