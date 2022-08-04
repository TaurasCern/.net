using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_homework
{
    internal class Bed
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Heigth { get; set; }
        public Bed(double length, double width, double heigth)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;
        }
        public Bed()
        {

        }
    }
}
