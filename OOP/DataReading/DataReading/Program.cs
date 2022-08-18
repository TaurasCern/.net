using DataReading.Domain.Models;
using DataReading.Domain.Services;
namespace DataReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileService basicUserFileService = new FileService(Environment.CurrentDirectory + "\\InitialData\\UserFirstNameBaseData1.csv");
            FileService userFileService = new FileService(Environment.CurrentDirectory + "\\InitialData\\UserData1.csv");
            FileService hotelFileService = new FileService(Environment.CurrentDirectory + "\\InitialData\\HotelData1.csv");
            
            var users = userFileService.FetchUserCsvRecords();
            var manager = new HotelManager(hotelFileService.FetchHotelCsvRecords());
            manager.AllocateUsersToHotels(users);

            //PrintHotelTenantAverageSalary(manager);
        }
        public static void PrintAllBasicUsers(List<BasicUser> basicUsers)
        {
            foreach(var user in basicUsers)
            {
                Console.WriteLine(user.Id);
            }
        }
        public static void PrintAllUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }
        public static void PrintHotelTenantAverageSalary(HotelManager manager)
        {
            foreach(var hotel in manager.Hotels)
            {
                Console.WriteLine(hotel.AverageClientSalary);
            }
        }
    }
}