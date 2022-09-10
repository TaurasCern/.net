using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Domain.Interfaces;

namespace LINQ.Domain.Models
{
    public class Character
    {
        public Character(string firstName, string lastName, int professionId, int gender)
        {
            FirstName = firstName;
            LastName = lastName;
            ProfessionId = professionId;
            Gender = gender;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Race { get; set; }
        public int ProfessionId { get; set; }
        public int Gender { get; set; }
    }
}
