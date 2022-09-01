using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace Generics_Tests
{
    [TestClass]
    public class EntityRepository_Tests
    {
        [TestMethod]
        public void Add_IUser()
        {
            IUser fakeUser = new BusinessClient(1, "vardas");
            var fakeEntityRep = new EntityRepository<IUser>();

            fakeEntityRep.Add(fakeUser);

            var expected = "vardas";
            var actual = fakeEntityRep.Fetch(1).Name;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_IUser()
        {
            IUser fakeUser = new BusinessClient(1, "vardas");
            var fakeEntityRep = new EntityRepository<IUser>();

            fakeEntityRep.Remove(fakeUser);

            var expected = 0;
            var actual = fakeEntityRep.Fetch().Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Fetch_Index_IUser()
        {
            IUser fakeUser1 = new BusinessClient(1, "vardas1");
            IUser fakeUser2 = new BusinessClient(2, "vardas2");
            var fakeEntityRep = new EntityRepository<IUser>();

            fakeEntityRep.Add(fakeUser1);
            fakeEntityRep.Add(fakeUser2);

            var expected = fakeUser2;
            var actual = fakeEntityRep.Fetch()[1];

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Name, actual.Name);
        }
    }
}
