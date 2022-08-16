using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika.Models
{
    internal class Person
    {
        private string name;
        private string lastName;
        private DateTime birthDate;
        private Pet pet;

        public Pet Pet
        {
            get { return pet; }
            set { pet = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string FullName
        {
            get { return Name + " " + LastName; }
        }

        public Person(string name, string lastName, DateTime birthDate)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public Person()
        {

        }
        public override string ToString() => string.Format(FullName + ", " + BirthDate.ToShortDateString());
    }
}
