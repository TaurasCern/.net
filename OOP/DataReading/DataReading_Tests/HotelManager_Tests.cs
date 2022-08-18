using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataReading.Domain.Models;
namespace DataReading_Tests
{
    [TestClass]
    public class HotelManager_Tests
    {
        [TestMethod]
        public void AverageRating_Test()
        {
            var fakeHotels = new List<Hotel>()
            {
                new Hotel("1,Hills Group,4,2,1/2/2012".Split(",")),
                new Hotel("2,Kihn and Sons,2,144,5/9/2014".Split(",")),
                new Hotel("3,Jakubowski-Nikolaus,3,16,9/11/2005".Split(",")),
            };

            var fakeHotelManager = new HotelManager(fakeHotels);

            var expected = (4d + 2d + 3d) / 3d;
            var actual = fakeHotelManager.AverageRating;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewHotels_Test()
        {
            var fakeHotels = new List<Hotel>()
            {
                new Hotel("1,Hills Group,4,2,1/2/2012".Split(",")),
                new Hotel("2,Kihn and Sons,2,144,5/9/2014".Split(",")),
                new Hotel("3,Jakubowski-Nikolaus,3,16,9/11/2005".Split(",")),
            };

            var fakeHotelManager = new HotelManager(fakeHotels);


            var expected = new List<Hotel>()
            {
                new Hotel("1,Hills Group,4,2,1/2/2012".Split(",")),
                new Hotel("2,Kihn and Sons,2,144,5/9/2014".Split(",")),
            };
            var actual = fakeHotelManager.NewHotels;

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AllocateUsersToLuxHotels_Test()
        {
            var fakeHotels = new List<Hotel>()
            {
                new Hotel("1,Hills Group,4,2,1/2/2012".Split(",")),
                new Hotel("2,Kihn and Sons,2,144,5/9/2014".Split(",")),
                new Hotel("3,Jakubowski-Nikolaus,3,16,9/11/2005".Split(",")),
            };

            var fakeUsers = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            var fakeHotelManager = new HotelManager(fakeHotels);


            var expected = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            fakeHotelManager.AllocateUsersToLuxHotels(fakeUsers);

            var actual = fakeHotelManager.Hotels[0].Tenants;

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
