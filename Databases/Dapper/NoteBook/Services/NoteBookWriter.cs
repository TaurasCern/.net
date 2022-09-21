using NoteBook.Database;
using NoteBook.Database.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Services
{
    public class NoteBookWriter : INoteBookWriter
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly NoteBookRepository _notebookRepository;

        public NoteBookWriter()
        {
            _databaseConfig = new DatabaseConfig();
            _notebookRepository = new NoteBookRepository(_databaseConfig);
        }

        public void Run()
        {
            char selection;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. List products");
                Console.WriteLine("3. Remove products by name");
                Console.WriteLine("q. Quit");

                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        AddProduct();
                        break;
                    case '2':
                        DisplayProducts();
                        break;
                    case '3':
                        RemoveProduct();
                        break;
                    case 'q':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                PauseScreen();
            }
        }
        public void DisplayProducts()
        {
            var products = _notebookRepository.Get();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}. {product.Title} - {product.Description}");
            }
        }

        public void AddProduct()
        {
            var newProduct = new Models.NoteBook();
            Console.WriteLine("enter name:");
            newProduct.Title = Console.ReadLine();
            Console.WriteLine("enter description:");
            newProduct.Description = Console.ReadLine();


            _notebookRepository.Create(newProduct);
            Console.WriteLine("irasas pridetas");
        }
        private void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }
        public void RemoveProduct()
        {
            Console.WriteLine("enter name to be deleted:");
            var nameToDelete = Console.ReadLine();


            var productsDeletedCount = _notebookRepository.Delete(nameToDelete);
            Console.WriteLine("isttrintu irasu kieki: {0}", productsDeletedCount);
        }
    }
}
