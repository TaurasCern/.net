using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Infrastructure.Database
{
    public class ManageDb
    {
        public ManageDb()
        {
            using (var context = new ShoeShopContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
