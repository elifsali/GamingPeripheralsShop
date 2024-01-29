using GamingPeripheralsShop.Models.Models.Request;
using GamingPeripheralsShop.Models.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingPeripheralsShop.BL.Interfaces
{
    public interface IStoreService
    {
        GetProductsByManufacturerResponse? GetProductsByManufacturer(GetProductsByManufacturerRequest request);
    }
}
