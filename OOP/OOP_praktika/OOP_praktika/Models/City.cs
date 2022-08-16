using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika.Models
{
    internal class City
    {
        public string Name { get; set; }
        public string[] Districts { get; set; }
        public int Population { get; set; }

        public City(string name, string[] districts, int population)
        {
            Name = name;
            Districts = districts;
            Population = population;
        }
        public City()
        {

        }
        public override string ToString() => Name + ", " + Population;
    }
}
