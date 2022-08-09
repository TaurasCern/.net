using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika
{
    internal class House
    {
        public string country;
        public string city;
        public string street;
        public string number;
        public int postalCode;
        public List<Person> tenants { get; set; } = new List<Person>();
        public string Address 
        { 
            get { return this.country + ", " + this.city + ", " + this.street + " " + this.number; }
        }
        public House()
        {
            this.country = "";
            this.city = "";
            this.street = "";
            this.number = "";
            this.postalCode = 0;
        }
        public House(string country, string city, string street, string number, int postalCode, List<Person> tenants)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.number = number;
            this.postalCode = postalCode;
            this.tenants = tenants;
        }
        public House(House house)
        {
            this.country = house.country;
            this.city = house.city;
            this.street = house.street;
            this.number = house.number;
            this.postalCode = house.postalCode;
            this.tenants = house.tenants;
        }

        public override string ToString() => this.Address + ", " + postalCode + Environment.NewLine + "Gyventojai: " + String.Join(", ", tenants);
    }
}
