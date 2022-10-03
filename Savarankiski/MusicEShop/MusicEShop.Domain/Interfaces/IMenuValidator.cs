using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEShop.Domain.Interfaces
{
    public interface IMenuValidator
    {
        bool ValidChoice(ConsoleKey choice);
    }
}
