using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeShop.Domain;

namespace ShoeShop.Infrastructure.Database.InitialData
{
    public static class ShoeInitialdata
    {
        public static Shoe[] DataSeed = new Shoe[]
        {
            new Shoe
            {
                Id = 1,
                Name = "Kedai",
                Type = "Vyriski",
                Price = 100M,
            },
                        new Shoe
            {
                Id = 2,
                Name = "Kedai",
                Type = "Moteriski",
                Price = 200M,
            },
                                    new Shoe
            {
                Id = 3,
                Name = "Kroksai",
                Type = "Vaikiski",
                Price = 20.01M,
            },
        };
    }
}
