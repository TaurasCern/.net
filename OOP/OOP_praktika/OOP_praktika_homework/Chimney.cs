using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_homework
{
    internal class Chimney
    {
        public string Material { get; set; }
        public string Colour { get; set; }
        public double Area { get; set; }

        public Chimney(string material, string colour, double area)
        {
            this.Material = material;
            this.Colour = colour;
            this.Area = area;
        }
        public Chimney()
        {

        }
    }
}
