using Microsoft.EntityFrameworkCore;
using ShoeShop.Domain;
using ShoeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Infrastructure.Database
{
    public class ShoeRepository : IShopRepository
    {
        private readonly ShoeShopContext _context;
        public ShoeRepository(ShoeShopContext context)
        {
            _context = context;
        }

        public List<Shoe> GetShoes() => _context.Shoes.Include(x => x.Sizes).ToList();

        public void InsertSaleAndDecreaseAmount(int sizeId, int amount)
        {
            var sale = new Sale
            {
                ShoeSizeId = sizeId,
                Amount = amount
            };
            _context.Add(sale);

            var shoeSize = _context.ShoeSizes.Find(sizeId);
            shoeSize.Amount = shoeSize.Amount - amount;

            _context.SaveChanges();
        }
    }
}
