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
        public void AddUser(User user)
        {
            Tenants.Add(user);
        }

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
    }
}
