using JsonExample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample
{
    public class SerializeDemo
    {
        public static void Show()
        {
            var author = new Author()
            {
                Name = "vardas pavarde",
                Courses = new string[] { "C#", "Java" },
                Happy = true
            };
            Console.WriteLine("-------------------------------");
            Console.WriteLine("serilizavimas");
            string json = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(json);


            Console.WriteLine("-------------------------------");
            Console.WriteLine("collection serialization");

            List<string> courses = new List<string> { "c#", "java", "T-SQL" };
            string jsonArray = JsonConvert.SerializeObject(courses, Formatting.Indented);
            Console.WriteLine(jsonArray);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("dictionary serialization");
            Dictionary<string, int> courseDictionary = new Dictionary<string, int>
            {
                {"C#", 10 },
                {"java", 20 },
                {"T-SQL", 333 }
            };

            string jsonDictionary = JsonConvert.SerializeObject(courseDictionary, Formatting.Indented);
            Console.WriteLine(jsonDictionary);



            var anonymousAuthor = new
            {
                Name = "vardas pavarde",
                Happy = true,
                Courses = new List<string>()
            };

            Console.WriteLine(JsonConvert.SerializeObject(anonymousAuthor));
        }
    }
}
