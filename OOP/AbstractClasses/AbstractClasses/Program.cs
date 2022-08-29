using AbstractClasses.Domain.InitialData;
using AbstractClasses.Domain.Services;
using AbstractClasses.Domain.Enums;
using AbstractClasses.Domain.Models.Abstract;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookService bookService = new BookService();

            Dictionary<EBookType, List<Book>> dictionary = bookService.Decode(BookInitialData.DataSeedHtml);

            foreach(KeyValuePair<EBookType, List<Book>> type in dictionary)
            {
                foreach(var book in type.Value)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
    }
}