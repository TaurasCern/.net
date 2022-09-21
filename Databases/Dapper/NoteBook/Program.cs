using NoteBook.Database.Dapper;
using NoteBook.Database;
using NoteBook.Services;

namespace NoteBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fetching connection string..");
            var dbConfig = new DatabaseConfig();
            Console.WriteLine("Starting up Database check..");
            DatabaseBootstrap databaseBootstrap = new DatabaseBootstrap(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check complete.");

            NoteBookWriter writer = new NoteBookWriter();
            writer.Run();
        }
    }
}