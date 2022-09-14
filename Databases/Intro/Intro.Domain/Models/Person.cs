using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Domain.Models
{
    public class Person
    {
        public Person() { }
        public Person(string firstName, string lastName, DateTime birthDate, string email, int height)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            Height = height;
        }

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; }
        public int? Height { get; set; }
        public double Weight { get; set; }
        public string? Biography { get; set; }
    }
}
