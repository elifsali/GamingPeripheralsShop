using GamingPeripheralsShop.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingPeripheralsShop.Models.Models.Response
{
    public class GetProductsByManufacturerResponse
    {
        public Manufacturer? Manufacturer { get; set; }
        public List<Product>? Products { get; set; }
    }
}
