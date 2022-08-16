using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_homework
{
    internal class Chair
    {
        public string Material { get; set; }
        public string Colour { get; set; }
        public double Heigth { get; set; }
        public Chair(string material, string colour, double heigth)
        {
            this.Material = material;
            this.Colour = colour;
            this.Heigth = heigth;
        }
        public Chair()
        {

        }
    }
}
