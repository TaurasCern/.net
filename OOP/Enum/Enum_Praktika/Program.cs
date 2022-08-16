namespace Enum_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new Society();
            people.FillPeople();
            people.FillMen();
            people.SortByFirstName().Asc();
            //foreach(var oldperson in people.OldPeople)
            //{
            //    Console.WriteLine(oldperson.Age);
            //}
            foreach(var man in people.Men)
            {
                Console.WriteLine(man.FirstName);
            }
        }
    }
}