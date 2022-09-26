using JsonExample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample
{
    public static class SerializeDeserializeDemo
    {
        public static void Show()
        {
            var json = InitialData.Samples.SingleJson();
            Console.WriteLine("json:");
            Console.WriteLine(json);
            //  deserialize
            Author author = JsonConvert.DeserializeObject<Author>(json);
            Console.WriteLine($"vardas: {author.Name}");

            author.Name = "pakeistas vardas";

            //  serialize
            string newJson = JsonConvert.SerializeObject(author);
            Console.WriteLine(newJson);

            // serialze - indented
            string newerJson = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(newerJson);
        }
    }
}
