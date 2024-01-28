using GamingPeripheralsShop.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingPeripheralsShop.DL.Interfaces
{
    public interface IManufacturerRepository
    {
        List<Manufacturer> GetAll();
        Manufacturer GetById(int id);
        void Add(Manufacturer manufacturer);
        void Remove(int id);
    }
}
