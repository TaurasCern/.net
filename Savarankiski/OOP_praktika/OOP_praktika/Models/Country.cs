using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika.Models
{
    internal class Country
    {
        public string Name { get; private set; }
        public string[] Rivers { get; private set; } = Array.Empty<string>();
        public List<City> Cities { get; private set; } = new List<City>();
        public Country()
        {
            Name = "";
        }
        public Country(string name) : this()
        {
            Name = name;
        }
        public Country(string name, string[] rivers, List<City> cities) : this(name)
        {
            Rivers = rivers;
            Cities = cities;
        }
        public Country(Country country)
        {
            Name = country.Name;
            Rivers = country.Rivers;
            Cities = country.Cities;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Name + ":" + Environment.NewLine);
            foreach (var city in Cities)
            {
                sb.Append(city.ToString()).Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
