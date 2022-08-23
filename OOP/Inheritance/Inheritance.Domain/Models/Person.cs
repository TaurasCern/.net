using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Domain.Enums;

namespace Inheritance.Domain.Models
{
    public class Person
    {
        public Person()
        {

        }
        public Person(EGenderType gender)
        {
            Gender = gender;
        }
        public Person(int id, string firstName, string lastName, EGenderType gender, DateTime birthDate, decimal height, decimal weight)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            BirthDate = birthDate;
            Height = height;
            Weight = weight;
        }

        public void SetGender(EGenderType gender)
        {
            Gender = gender;
        }
        private int? CalculateAge()
        {
            if (BirthDate == null)
            {
                return null;
            }

            var ts = DateTime.Now.Subtract((DateTime)BirthDate);
            return new DateTime(ts.Ticks).Year - 1;
        }
        public override string ToString() => $"{FullName}, {Age}, {Gender}";

        public override bool Equals(object? obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            var other = obj as Person;
           

            return this.Id == other.Id
                    && this.FullName.Equals(other.FullName) 
                    && this.BirthDate.Equals(other.BirthDate);
        }
        public string GetPersonCsv() => String.Join(",", Id, FirstName, LastName, Gender, BirthDate, Height, Weight);

        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!string.IsNullOrEmpty(_firstName))
                {
                    NameChanges += $"{FullName},{value} {_lastName}{Environment.NewLine}";
                }
                _firstName = value;
            }
        }
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!string.IsNullOrEmpty(_lastName))
                {
                    NameChanges += $"{FullName},{_firstName} {value}{Environment.NewLine}";
                }
                _lastName = value;
            }
        }
        public string FullName { get => $"{_firstName} {_lastName}"; }
        public EGenderType Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int? Age { get => CalculateAge(); }
        public string NameChanges { get; private set; }

    }
}
