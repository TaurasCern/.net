using QueryingSQLite.Infrastructure.Database;

namespace QueryingSQLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var manageDb = new ManageDb();

            //manageDb.AddBlog("Programavimas");

            //manageDb.AddPost("CSharp", 1);
            manageDb.AddAuthor("Petras", "Petrauskas", 1);
        }
    }
}