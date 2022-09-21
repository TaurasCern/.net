using DapperExample.Database;
using DapperExample.Database.Dapper;
using DapperExample.Services;

namespace DapperExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fetching connection string..");
            var dbConfig = new DatabaseConfig();
            Console.WriteLine("Starting up Database check..");
            IDatabaseBootstrap databaseBootstrap = new DatabaseBootStrap(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check complete.");

            IProductService productService = new ProductService();
            productService.Run();
        }
    }
}