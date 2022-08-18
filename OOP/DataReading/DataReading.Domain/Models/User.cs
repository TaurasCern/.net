using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataReading.Domain.Enums;

namespace DataReading.Domain.Models
{
    public class User
    {
        public User()
        {

        }

        public User(string[] userData)
        {
            Id = Convert.ToInt32(userData[0]);
            FirstName = userData[1];
            LastName = userData[2];
            Email = userData[3];
            if (userData[4] == "Male")
            {
                Gender = EGender.Male;
            }
            else if (userData[4] == "Female")
            {
                Gender = EGender.Female;
            }
            Salary = Convert.ToInt32(userData[5]);
            FavoriteColor = userData[6];
            BirthDate = Convert.ToDateTime(userData[7]);

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EGender Gender { get; set; }
        public int Salary { get; set; }
        public string FavoriteColor { get; set; }
        public DateTime BirthDate { get; set; }


        public override string ToString() => $"{Id}. {FirstName} {LastName} ({Gender}) - {Email}";

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is User)) return false;

            var other = obj as User;

            return Id == other.Id 
                && FirstName.Equals(other.FirstName)
                && LastName.Equals(other.LastName)
                && Email.Equals(other.Email)
                && Salary == other.Salary
                && BirthDate.Equals(other.BirthDate);
        }
    }
}
