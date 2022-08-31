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
            EntityRepository fakeEntityRep = new EntityRepository<BusinessClient>();

            fakeEntityRep.Add(fakeUser);
            
        }
    }
}
