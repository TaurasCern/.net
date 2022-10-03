using Microsoft.EntityFrameworkCore;
using MusicEShop.Domain.Interfaces;
using MusicEShop.Domain.Models;
using MusicEShop.Domain.Services;
using MusicEShop.Infrastructure.Database;

namespace MusicEShop.Infrastructure_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private chinookContext context; 

       [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<chinookContext>()
                .UseInMemoryDatabase(databaseName: "chinook")
                .Options;
            context = new chinookContext(options);
            context.Tracks.Add(new Track { TrackId = 1, Name = "Pavadinimas1", MediaTypeId = 1, Milliseconds = 300000, Status = "Active" });
            context.Tracks.Add(new Track { TrackId = 2, Name = "Pavadinimas2", MediaTypeId = 1, Milliseconds = 350000, Status = "Active" });

            context.Customers.Add(new Customer { CustomerId = 1, FirstName = "Vardas1", LastName = "Pavarde1", Email = "email@email.com" });
            context.SaveChanges();
        }



        [TestMethod]
        public void Handle_CustomerMenu_IEnumerableCustomers()
        {
            IMusicEShopRepository repository = new MusicEShopRepository(context);
            IMenuStateHandler menuHandler = new MenuStateHandler();
            IInputService input = new InputService(menuHandler);
            IMenuService menuService = new MenuService(menuHandler);
            IMusicEShopRepositoryHandler<IEnumerable<object>> repositoryHandler = new MusicEShopRepositoryHandler<IEnumerable<object>>(
                menuHandler, repository, input, menuService);

            menuHandler.SetMenuState("Customer menu");

            var actual = (Customer)repositoryHandler.Handle().FirstOrDefault();

            var expected = new Customer { CustomerId = 1, FirstName = "Vardas1", LastName = "Pavarde1", Email = "email@email.com" };

            Assert.AreEqual(actual.CustomerId, expected.CustomerId);
            Assert.AreEqual(actual.Email, expected.Email);
        }
        [TestMethod]
        public void Handle_UpdateTrackStatus()
        {
            IMusicEShopRepository repository = new MusicEShopRepository(context);
            IMenuStateHandler menuHandler = new MenuStateHandler();
            IInputService input = new InputService(menuHandler);
            MenuService menuService = new MenuService(menuHandler);
            IMusicEShopRepositoryHandler<IEnumerable<object>> repositoryHandler = new MusicEShopRepositoryHandler<IEnumerable<object>>(
                menuHandler, repository, input, menuService);

            menuService.SetTrack(context.Tracks.Find(1));
            menuHandler.SetMenuState("Change track");

            var actual = context.Tracks.Find(1);
            var expected = new Track() { TrackId = 1, Name = "Pavadinimas1", MediaTypeId = 1, Milliseconds = 300000, Status = "Inactive" };

            Assert.AreEqual(actual.TrackId, expected.TrackId);
            Assert.AreEqual(actual.Status, expected.Status);
        }



        [TestMethod]
        public void Repository()
        {
            IMusicEShopRepository repository = new MusicEShopRepository(context);

            var actual = repository.GetAllCustomers().ToList().First();
            var expected = new Customer { CustomerId = 1, FirstName = "Vardas1", LastName = "Pavarde1", Email = "email@email.com" };


            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        }
    }
}