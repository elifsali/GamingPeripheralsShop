﻿using GamingPeripheralsShop.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GamingPeripheralsShop.BL.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Remove(int id);
    }
}
