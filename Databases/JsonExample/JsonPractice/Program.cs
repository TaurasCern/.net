using Newtonsoft.Json;
namespace JsonPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string> { "Starcraft", "Halo", "Legend of Zelda" };
            Dictionary<string, int> points = new Dictionary<string, int>
            {
                { "James", 9001 },
                { "Jo", 3474 },
                { "Jess", 11926 }
            };

            var account = new
            {
                email = "james@example.com",
                active = true,
                createdDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                roles = new List<string>
                {
                    "User",
                    "Admin"
                }
            };
            var movie = new { name = "Bad Boys", year = 1995 };


            Console.WriteLine(JsonConvert.SerializeObject(games));
            Console.WriteLine(JsonConvert.SerializeObject(points));
            Console.WriteLine(JsonConvert.SerializeObject(account, Formatting.Indented));
            File.WriteAllText(Environment.CurrentDirectory + "//movie.json", JsonConvert.SerializeObject(movie));
        }
    }
}