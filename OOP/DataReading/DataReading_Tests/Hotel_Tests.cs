using DataReading.Domain.Models;
namespace DataReading_Tests
{
    [TestClass]
    public class Hotel_Tests
    {
        [TestMethod]
        public void AverageClientSalary_Test()
        {
            var fakeTenants = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            var fakeHotel = new Hotel();
            fakeHotel.AddUsers(fakeTenants);

            double expected = (4508d + 5930d + 4278d) / 3d;
            var actual = fakeHotel.AverageClientSalary;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenVisitors_Test()
        {
            var fakeTenants = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            var fakeHotel = new Hotel();
            fakeHotel.AddUsers(fakeTenants);

            var expected = new List<User>() 
            {
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };


            var actual = fakeHotel.MenVisitors;

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void WomenVisitors_Test()
        {
            var fakeTenants = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            var fakeHotel = new Hotel();
            fakeHotel.AddUsers(fakeTenants);

            var expected = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
            };


            var actual = fakeHotel.WomenVisitors;

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddUser_Test()
        {
            var fakeUser = new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(","));

            var fakeHotel = new Hotel();
            fakeHotel.AddUser(fakeUser);

            var expected = new List<User>() { fakeUser };

            var actual = fakeHotel.Tenants;

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddUsers_Test()
        {
            var fakeUsers = new List<User>()
            {
                new User("1,Viv,Joberne,vjoberne0@dailymail.co.uk,Female,4508,Khaki,2/27/2010".Split(",")),
                new User("2,Trefor,Wellings,twellings1@angelfire.com,Male,5930,Green,1/2/1918".Split(",")),
                new User("3,Xymenes,O'Hern,xohern2@histats.com,Male,4278,Aquamarine,3/30/1908".Split(",")),
            };

            var fakeHotel = new Hotel();
            fakeHotel.AddUsers(fakeUsers);

            var expected = new List<User>(fakeUsers);

            var actual = fakeHotel.Tenants;

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}