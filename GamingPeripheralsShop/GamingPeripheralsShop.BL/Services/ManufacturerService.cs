using GamingPeripheralsShop.BL.Interfaces;
using GamingPeripheralsShop.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingPeripheralsShop.DL.Interfaces;

namespace GamingPeripheralsShop.BL.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerService(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        public void Add(Manufacturer manufacturer)
        {
            _manufacturerRepository.Add(manufacturer);
        }

        public List<Manufacturer> GetAll()
        {
            return _manufacturerRepository.GetAll();
        }

        public Manufacturer GetById(int id)
        {
            return _manufacturerRepository.GetById(id);
        }

        public void Remove(int id)
        {
            _manufacturerRepository.Remove(id);
        }
    }
}
