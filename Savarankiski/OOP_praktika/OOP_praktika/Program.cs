namespace OOP_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var house = new House("Lietuva", "Kaunas", "Gatve g.", "14", 11111, new List<Person> { new Person("Vardas", "Pavarde", new DateTime(1999,1,1)) });
            Console.WriteLine(house.ToString());
            Console.WriteLine();

            var country = new Country("Lietuva", new string[] {"Nemunas", "Neris"}, new List<City> { new City("Kaunas", new string[] {"Aleksotas", "Centras"}, 100000) });
            Console.WriteLine(country.ToString());
            Console.WriteLine();

            var book = new Book("Knygos pavadinimas", "Knygos aprasas...", new string[] {"aaaa", "bbbb","cccc"});
            Console.WriteLine(book.ToString());
            Console.WriteLine();
        }
    }
}