using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_homework
{
    internal class Table
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Heigth { get; set; }
        public Shelve[] Shelves { get; set; }
        public Table(double length, double width, double heigth, Shelve[] shelves)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;
            this.Shelves = shelves;
        }
        public Table()
        {

        }
    }
}
