using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReading.Domain.Models
{
    public class Hotel
    {
        public Hotel()
        {

        }

        public Hotel(string[] hotelData)
        {
            Id = Convert.ToInt32(hotelData[0]);
            Name = hotelData[1];
            Rating = Convert.ToInt32(hotelData[2]);
            StreetNumber = Convert.ToInt32(hotelData[3]);
            CreationDate = Convert.ToDateTime(hotelData[4]);

        }
        public List<User> Tenants { get; set; } = new List<User>();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int StreetNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public double AverageClientSalary
        {
            get
            {
                double avgSalary = 0;
                foreach(var tenant in Tenants)
                {
                    avgSalary += tenant.Salary;
                }

                return avgSalary / Tenants.Count;
            }
        }
        public List<User> MenVisitors 
        {
            get
            {
                List<User> menVisitors = new List<User>();
                foreach(var visitor in Tenants)
                {
                    if(visitor.Gender == Enums.EGender.Male)
                    {
                        menVisitors.Add(visitor);
                    }
                }
                return menVisitors;
            }
        }
        public List<User> WomenVisitors
        {
            get
            {
                List<User> womenVisitors = new List<User>();
                foreach (var visitor in Tenants)
                {
                    if (visitor.Gender == Enums.EGender.Female)
                    {
                        womenVisitors.Add(visitor);
                    }
                }
                return womenVisitors;
            }
        }
        public void AddUser(User user)
        {
            Tenants.Add(user);
        }
        public void AddUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Tenants.Add(user);
            }         
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Hotel)) return false;

            var other = obj as Hotel;

            return Id == other.Id
                && Name.Equals(other.Name)
                && StreetNumber == other.StreetNumber
                && CreationDate.Equals(other.CreationDate);
        }
    }
}
