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
