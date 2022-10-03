using MusicEShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEShop.Domain.Interfaces
{
    public interface IMenuService
    {
        public Customer Customer { get; }
        public Track Track { get; }
        public Invoice Cart { get; }

        void Process<T>(T data);
    }
}
