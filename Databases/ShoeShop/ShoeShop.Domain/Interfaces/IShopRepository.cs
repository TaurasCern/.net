using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Domain.Interfaces
{
    public interface IShopRepository
    {
        List<Shoe> GetShoes();
        void InsertSaleAndDecreaseAmount(int sizeId, int amount);
    }
}
