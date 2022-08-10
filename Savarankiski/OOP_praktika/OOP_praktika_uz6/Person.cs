using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_uz6
{
    internal class Person
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Bendrabutis Dormitory { get; private set; }
        public string FullName { get => $"{Name} {LastName}"; }
        public Person(string name, string lastName, DateTime birthDate, Bendrabutis dormitory)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
            Dormitory = dormitory;
        }
        public Person()
        {

        }
        public override string ToString() => string.Format(FullName + ", " + BirthDate.ToShortDateString());
    }
}
