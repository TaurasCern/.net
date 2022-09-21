using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeShop.Domain.Interfaces;
using ShoeShop.Domain;
using ShoeShop.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Infrastructure.Database.Tests
{
    [TestClass()]
    public class ShoeRepository_Tests
    {
        private ShoeShopContext context;

        public object IShoeRepository { get; private set; }

        [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<ShoeShopContext>()
                .UseInMemoryDatabase(databaseName: "Shop")
                .Options;

            context = new ShoeShopContext(options);
            context.Shoes.AddRange(new Shoe[]
{
                new Shoe {
                    Id = 1,
                    Name = "Kedai",
                    Type = "Vyriški",
                    Price = 100M,
                },
            });
            context.ShoeSizes.AddRange(new ShoeSize[]
            {
                new ShoeSize { Id = 1, ShoeId = 1, Size = 42, Amount = 10},
                new ShoeSize { Id = 2, ShoeId = 1, Size = 43, Amount = 11},
                new ShoeSize { Id = 3, ShoeId = 1, Size = 44, Amount = 12},
                new ShoeSize { Id = 4, ShoeId = 1, Size = 45, Amount = 14},
            });
            context.SaveChanges();
        }
        [TestMethod()]
        public void InsertSaleAndDecreaseAmount_Test()
        {
            IShopRepository shop = new ShoeRepository(context);
            shop.InsertSaleAndDecreaseAmount(2, 5);

            Assert.AreEqual(6, context.ShoeSizes.Find(2).Amount);
            Assert.AreEqual(5, context.Sales.First(x => x.ShoeSizeId == 2).Amount);
            Assert.AreEqual(500, context.Sales.First(x => x.ShoeSizeId == 2).SpentAmount);

        }
    }
}