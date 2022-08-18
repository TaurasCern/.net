using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReading.Domain.Models
{
    public class HotelManager
    {
        public HotelManager()
        {

        }
        public HotelManager(List<Hotel> hotels)
        {
            Hotels = hotels;
        }
        public List<Hotel> Hotels { get; set; } = new List<Hotel>();

        public double AverageRating 
        {
            get
            {
                double avg = 0;
                foreach (var hotel in Hotels)
                {
                    avg += hotel.Rating;
                }
                return avg / Hotels.Count;
            }
        }
        public List<Hotel> NewHotels 
        {
            get
            {
                var newHotels = new List<Hotel>();
                foreach(var hotel in Hotels)
                {
                    if(hotel.CreationDate > new DateTime(2010, 1, 1))
                    {
                        newHotels.Add(hotel);
                    }
                }
                return newHotels;
            } 
        }
        public void AllocateUsersToLuxHotels(List<User> users)
        {
            foreach(var hotel in NewHotels)
            {
                if(hotel.Rating > 3)
                {
                    foreach(var user in users)
                    {
                        hotel.AddUser(user);
                    }
                }
            }
        }
        public void AllocateUsersToHotels(List<User> users)
        {
            Random random = new Random();
            foreach(var user in users)
            {
                Hotels[random.Next(Hotels.Count)].AddUser(user);
            }
        }
    }
}
