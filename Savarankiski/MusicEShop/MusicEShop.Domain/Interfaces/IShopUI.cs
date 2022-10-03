using MusicEShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEShop.Domain.Interfaces
{
    public interface IShopUI
    {
        void PrintMenu<T>(T result, Customer customer, Invoice cart);
    }
}
