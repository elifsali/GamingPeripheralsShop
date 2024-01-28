using GamingPeripheralsShop.Models.Models.User;

namespace GamingPeripheralsShop.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Manufacturer> ManufacturerData = new List<Manufacturer>()
        {
            new Manufacturer()
            {
                Id = 1,
                Name = "Razer",
                Country = "United States",
            },
            new Manufacturer()
            {
                Id = 2 ,
                Name = "Logitech",
                Country = "Switzerland",
            },
            new Manufacturer()
            {
                Id = 3,
                Name = "Glorious",
                Country = "United States",
            }
        };

        public static List<Product> ProductData = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Razer BlackShark V2 Pro Wireless Gaming Headset",
                Price = 127.77m,
                ManufacturerId = 1,
            },
            new Product()
            {
                Id = 2,
                Name = "Logitech G715 Wireless Gaming Keyboard",
                Price = 226.5m,
                ManufacturerId = 2,
            },
            new Product()
            {
                Id = 3,
                Name = "Glorious Model O 2 Wireless Gaming Mouse",
                Price = 79.99m,
                ManufacturerId = 3,
            },
        };
    }
}
