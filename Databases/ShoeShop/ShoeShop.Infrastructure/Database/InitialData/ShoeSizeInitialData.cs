using ShoeShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Infrastructure.Database.InitialData
{
    public static class ShoeSizeInitialData
    {
        public static ShoeSize[] DataSeed => new ShoeSize[]
        {
            new ShoeSize {Id = 1, ShoeId = 1, Size = 42, Amount = 10 },
            new ShoeSize {Id = 2, ShoeId = 1, Size = 43, Amount = 11 },
            new ShoeSize {Id = 3, ShoeId = 1, Size = 44, Amount = 12},
            new ShoeSize {Id = 4, ShoeId = 1, Size = 45, Amount = 13 },
            // --
            new ShoeSize {Id = 5, ShoeId = 2, Size = 36, Amount = 10 },
            new ShoeSize {Id = 6, ShoeId = 2, Size = 37, Amount = 11 },
            new ShoeSize {Id = 7, ShoeId = 2, Size = 38, Amount = 12},
            new ShoeSize {Id = 8, ShoeId = 2, Size = 39, Amount = 13 },
            // --
            new ShoeSize {Id = 9,  ShoeId = 3, Size = 30, Amount = 10 },
            new ShoeSize {Id = 10, ShoeId = 3, Size = 31, Amount = 11 },
            new ShoeSize {Id = 11, ShoeId = 3, Size = 32, Amount = 12},
            new ShoeSize {Id = 12, ShoeId = 3, Size = 33, Amount = 13 },
        };
    }
}
