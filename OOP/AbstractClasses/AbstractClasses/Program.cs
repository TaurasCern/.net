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

            List<Book> books = new List<Book>();
            books.AddRange(dictionary[EBookType.EBook]);
            books.AddRange(dictionary[EBookType.AudioBook]);
            books.AddRange(dictionary[EBookType.HardcoverBook]);
            books.AddRange(dictionary[EBookType.PaperbackBook]);

            Console.WriteLine(bookService.Encode(books));

            //foreach(KeyValuePair<EBookType, List<Book>> type in dictionary)
            //{
            //    foreach(var book in type.Value)
            //    {
            //        Console.WriteLine(book.Type);
            //    }
            //}
        }
    }
}