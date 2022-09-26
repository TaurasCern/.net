using JsonExample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample
{
    public class DeserializeObjectDemo
    {
        public static void Show()
        {
            string jsonString = @"{
            'name':'vardas pavarde',
            'courses':['C#', 'T-SQL'],
            'happy':true}";

            Author author = JsonConvert.DeserializeObject<Author>(jsonString);

            Console.WriteLine("vardas: " + author.Name);


            var author2 = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine(author2);



            var jsonFromFile = File.ReadAllText(Environment.CurrentDirectory + "\\InitialData\\" + "author.json");
            Author authorfromFile = JsonConvert.DeserializeObject<Author>(jsonFromFile);
            Console.WriteLine(authorfromFile.Name);
        }
    }
}
