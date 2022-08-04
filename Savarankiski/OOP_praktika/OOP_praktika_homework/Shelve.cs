using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_homework
{
    internal class Shelve
    {
        public string Length { get; set; }
        public string Width { get; set; }
        public string Heigth { get; set; }

        public Shelve(string length, string width, string heigth)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;
        }
        public Shelve()
        {

        }
    }
}
