using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika
{
    internal class Country
    {
        public string Name { get; set; }
        public string[] Rivers { get; set; }
        public List<City> Cities { get; set; }
        public Country(string name, string[] rivers, List<City> cities)
        {
            this.Name = name;
            this.Rivers = rivers;
            this.Cities = cities;
        }
        public Country()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(this.Name + ":" + Environment.NewLine);
            foreach(var city in this.Cities)
            {
                sb.Append(city.ToString()).Append(Environment.NewLine);
            }
            return sb.ToString();
        } 
    }
}
