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
    public class ManufacturerRepository : IManufacturerRepository
    {
        public List<Manufacturer> GetAll()
        {
            return InMemoryDb.ManufacturerData;
        }
        public Manufacturer GetById(int id)
        {
            return InMemoryDb.ManufacturerData.First(a => a.Id == id);
        }
        public void Add(Manufacturer manufacturer)
        {
            InMemoryDb.ManufacturerData.Add(manufacturer);
        }
        public void Remove(int id)
        {
            var manufacturer = GetById(id);
            InMemoryDb.ManufacturerData.Remove(manufacturer);
        }
    }
}
