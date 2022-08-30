using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Domain.Models.Abstract;

namespace AbstractClasses.Domain.Models.Concrete
{
    public class BookHtml
    {
        public BookHtml()
        {

        }
        public BookHtml(Book book)
        {
            Genre = book.Genre;
            Title = book.Title;
            Author = book.Author;
            BooksSold = book.BooksSold;
            Quantity = book.Quantity;

            if(book.Type.Equals("EBook")) { EBookPrice = book.Price; }
            else if(book.Type.Equals("AudioBook")) { AudioBookPrice = book.Price; }
            else if(book.Type.Equals("HardcoverBook")) { HardcoverBookPrice = book.Price; }
            else if(book.Type.Equals("PaperbackBook")) { PaperbackBookPrice = book.Price; }
        }
        public BookHtml(string genre, string title, string author, int booksSold, int? quantity, double? eBookPrice, double? audioBookPrice, double? hardcoverBookPrice, double? paperbackBookPrice)
        {
            Genre = genre;
            Title = title;
            Author = author;
            BooksSold = booksSold;
            Quantity = quantity;
            EBookPrice = eBookPrice;
            AudioBookPrice = audioBookPrice;
            HardcoverBookPrice = hardcoverBookPrice;
            PaperbackBookPrice = paperbackBookPrice;
        }

        public string Genre { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int BooksSold { get; set; }
        public int? Quantity { get; set; }
        public double? EBookPrice { get; set; }
        public double? AudioBookPrice { get; set; }
        public double? HardcoverBookPrice { get; set; }
        public double? PaperbackBookPrice { get; set; }
        public int PriceCount { get; internal set; }

        internal void SetPrice(double? price, string type)
        {
            if (type.Equals("EBook")) { EBookPrice = price; }
            else if (type.Equals("AudioBook")) { AudioBookPrice = price; }
            else if (type.Equals("HardcoverBook")) { HardcoverBookPrice = price; }
            else if (type.Equals("PaperbackBook")) { PaperbackBookPrice = price; }
        }
    }
}
