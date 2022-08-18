namespace Enum_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new Society();
            people.FillPeople();
            people.SortByFirstName().Asc();

            foreach(var person in people.People)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}