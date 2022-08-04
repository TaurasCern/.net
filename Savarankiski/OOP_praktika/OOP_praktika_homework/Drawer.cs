using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_homework
{
    internal class Drawer
    {
        public string Material { get; set; }
        public string Colour { get; set; }
        public string[] Items { get; set; }
        public Drawer(string material, string colour, string[] items)
        {
            this.Material = material;
            this.Colour = colour;
            this.Items = items;
        }
        public Drawer()
        {
                
        }
    }
}
