using GamingPeripheralsShop.DL.Interfaces;
using GamingPeripheralsShop.BL.Services;
using GamingPeripheralsShop.Models.Models.User;
using Moq;

namespace GamingPeripheralsShop.Test
{
    public class ProductTest
    {
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
        [Fact]
        public void GetAllByManufacturerId_Count_Check()
        {
            var expectedCount = 1;
            var manufacturerId = 2;

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(x => x.GetAllProductsByManufacturerId(manufacturerId))
                .Returns(ProductData.Where(p => p.ManufacturerId == manufacturerId).ToList());

            //injects
            var service = new ProductService(mockedProductRepository.Object);

            //act
            var result = service.GetAllProductsByManufacturerId(manufacturerId);

            //assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void GetAllByManufacturerId_WrongId()
        {
            var expectedCount = 0;
            var manufacturerId = 4;

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(x => x.GetAllProductsByManufacturerId(manufacturerId))
                .Returns(ProductData.Where(p => p.ManufacturerId == manufacturerId).ToList());

            //injects
            var service = new ProductService(mockedProductRepository.Object);

            //act
            var result = service.GetAllProductsByManufacturerId(manufacturerId);

            //assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void TestCalculation_Result_Check()
        {
            var expectedResult = 13;
            var testNumber = 10;

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(x => x.GetAll())
                .Returns(ProductData);

            //injects
            var service = new ProductService(mockedProductRepository.Object);

            //act
            var result = service.TestCalculation(testNumber);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Remove_Count_Check()
        {
            var expectedResult = 2;
            var productId = 1;
            var productToRemove = ProductData.FirstOrDefault(x => x.Id == productId);

            var mockedProductRepository = new Mock<IProductRepository>();
            mockedProductRepository.Setup(x => x.Remove(productId)).Callback(() =>
            {
                ProductData.Remove(productToRemove);
            });

            //injects
            var service = new ProductService(mockedProductRepository.Object);

            //act
            service.Remove(productId);

            //assert
            Assert.Equal(expectedResult, ProductData.Count);
        }
    }
}
