using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Domain.Enums;
using AbstractClasses.Domain.Interfaces;
using AbstractClasses.Domain.Models.Abstract;
using AbstractClasses.Domain.Models.Concrete;
using AbstractClasses.Domain.InitialData;

namespace AbstractClasses.Domain.Services
{
    public class BookService : IBookHtmlService
    {
        public Dictionary<EBookType, List<Book>> Decode(string dataSeed)
        {
            var books = new Dictionary<EBookType, List<Book>>()
            {
                { EBookType.AudioBook, new List<Book>() },
                { EBookType.EBook, new List<Book>() },
                { EBookType.PaperbackBook, new List<Book>() },
                { EBookType.HardcoverBook, new List<Book>() }
            };

            int index = 21; // html line index
            string[] lines = dataSeed.Split(Environment.NewLine);

            while(lines.Length > index + 5)
            {
                var genre = TrimCell(lines[index]);
                var title = TrimCell(lines[index + 1]);
                var author = TrimCell(lines[index + 2]);
                var booksSold = ParseBooksSold(TrimCell(lines[index + 3]));
                int? quantity = ParseQuantity(TrimCell(lines[index + 4]));

                books[EBookType.EBook].Add(new EBook(genre, title, author, booksSold, quantity, 
                    GetPrice(TrimCell(lines[index + 5]))));

                books[EBookType.AudioBook].Add(new AudioBook(genre, title, author, booksSold, quantity, 
                    GetPrice(TrimCell(lines[index + 6]))));

                books[EBookType.HardcoverBook].Add(new HardcoverBook(genre, title, author, booksSold, quantity, 
                    GetPrice(TrimCell(lines[index + 7]))));

                books[EBookType.PaperbackBook].Add(new PaperbackBook(genre, title, author, booksSold, quantity, 
                    GetPrice(TrimCell(lines[index + 8]))));

                index = index + 11;   // next row in html table                            
            }

            return books;
        }

        public string Encode(List<Book> books)
        {
            var booksHtml = new List<BookHtml>();
            bool flag = false;

            foreach (var book in books)
            {
                if (booksHtml.Count == 0)
                {
                    booksHtml.Add(new BookHtml(book));
                    continue;
                }
                for (int i = 0; i < booksHtml.Count; i++)
                {
                    if (booksHtml[i].Title.Equals(book.Title))
                    {                                          
                        booksHtml[i].SetPrice(book.Price, book.Type);
                    }
                    else if (!ContainsTitle(booksHtml, book.Title))
                    {
                        flag = true;
                    }
                }
                if (flag) 
                { 
                    booksHtml.Add(new BookHtml(book) { PriceCount = 1}); 
                    flag = false;                 
                }               
            }

            return booksHtml.ToHtml();
        }
        private bool ContainsTitle(List<BookHtml> books, string title)
        {
            foreach(var book in books)
            {
                if (book.Title.Equals(title))
                {
                    return true;
                }
            }
            return false;
        }
        private string TrimCell(string text) => text.Trim().Replace("<td>", "").Replace("</td>", "");
        private int? ParseQuantity(string text)
        {
            if (!text.Equals("-"))
            {
                return Convert.ToInt32(text);
            }
            return null;
        }
        private int ParseBooksSold(string text)
        {
            if (text.ToLower().Contains("million"))
            {
                return Convert.ToInt32(text.ToLower().Replace("million", "")) * 1000000;
            }
            else if (text.ToLower().Contains("billion"))
            {
                return Convert.ToInt32(Convert.ToDouble(text.ToLower().Replace("billion", "")) * 1000000000);
            }

            return Convert.ToInt32(text);
        }
        private double? GetPrice(string priceText)
        {          
            if(priceText.Contains("EUR")) { return Convert.ToDouble(priceText.Replace("EUR", "")); }
            if(priceText.Contains("$")) { return Convert.ToDouble(priceText.Replace("$", "")) * 1; }
            if(priceText.Contains("PLN")) { return Convert.ToDouble(priceText.Replace("PLN", "")) * 0.21; }
            
            return null;
        }
    }
}
