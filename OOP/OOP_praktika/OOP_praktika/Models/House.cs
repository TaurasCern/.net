using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika.Models
{
    internal class House
    {
        private string country;
        private string city;
        private string street;
        private string number;
        private int postalCode;
        public List<Person> tenants { get; private set; } = new List<Person>();
        public string Address
        {
            get { return country + ", " + city + ", " + street + " " + number; }
        }
        public House()
        {
            country = "";
            city = "";
            street = "";
            number = "";
            postalCode = 0;
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
            country = house.country;
            city = house.city;
            street = house.street;
            number = house.number;
            postalCode = house.postalCode;
            tenants = house.tenants;
        }

        public string getCountry() => country;
        public string getCity() => city;
        public string getStreet() => street;
        public string getNumber() => number;            
        public int getPostalCode() => postalCode;
        public Person getTenant(int index) => tenants[index];

        public override string ToString() => Address + ", " + postalCode + Environment.NewLine + "Gyventojai: " + string.Join(", ", tenants);
    }
}
