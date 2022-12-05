using MusicEShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEShop.Domain.Interfaces
{
    public interface IInputService
    {
        public int InputInt();
        public string InputString();
        public string Search();
        public string Update();
        public Customer InputCustomer();
        public int TrackId();
    }
}
