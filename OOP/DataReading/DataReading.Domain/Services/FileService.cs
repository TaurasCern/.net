using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataReading.Domain.Models;

namespace DataReading.Domain.Services
{
    public class FileService
    {
        public FileService(string filePath)
        {
         _filePath = filePath;
        }
        private string _filePath;

        public List<BasicUser> FetchBasicUserCsvRecords()
        {
            int userCollumnCount = 2;

            List<BasicUser> users = new List<BasicUser>();

            using StreamReader sr = new StreamReader(_filePath);

            string userLine;
            sr.ReadLine();

            while((userLine = sr.ReadLine()) != null)
            {              
                string[] userData = userLine.Split(",");
                if (userData.Length != userCollumnCount) break;

                BasicUser newUser = new BasicUser(userData);
                users.Add(newUser);
            }

            return users;
        }

        public List<User> FetchUserCsvRecords()
        {
            int userCollumnCount = 8;

            List<User> users = new List<User>();

            using StreamReader sr = new StreamReader(_filePath);

            string userLine;
            sr.ReadLine();

            while ((userLine = sr.ReadLine()) != null)
            {
                string[] userData = userLine.Split(",");
                if (userData.Length != userCollumnCount) break;

                User newUser = new User(userData);
                users.Add(newUser);
            }

            return users;
        }

        public List<Hotel> FetchHotelCsvRecords()
        {
            int hotelCollumnCount = 5;

            List<Hotel> hotels = new List<Hotel>();

            using StreamReader sr = new StreamReader(_filePath);

            string hotelLine;

            sr.ReadLine();

            while ((hotelLine = sr.ReadLine()) != null)
            {
                
                string[] hotelData = hotelLine.Split(",");
                if (hotelData.Length != hotelCollumnCount) break;

                Hotel newHotel = new Hotel(hotelData);

                hotels.Add(newHotel);
            }
            return hotels;
        }
    }
}
