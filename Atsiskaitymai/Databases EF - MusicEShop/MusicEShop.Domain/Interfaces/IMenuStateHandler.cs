using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEShop.Domain.Interfaces
{
    public interface IMenuStateHandler
    {
        public bool IsChoice { get; set; }
        public string SearchQuery { get; set; }
        string GetMenuState();
        void SetMenuState(string state);
        void Menu(ConsoleKey choice);
    }
}
