using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_homework
{
    internal class Wardrobe
    {
        public string Material { get; set; }
        public string Colour { get; set; }
        public Shelve[] Shelves { get; set; }
        public Wardrobe(string material, string colour, Shelve[] shelves)
        {
            this.Material = material;
            this.Colour = colour;
            this.Shelves = shelves;
        }
        public Wardrobe()
        {

        }
    }
}
