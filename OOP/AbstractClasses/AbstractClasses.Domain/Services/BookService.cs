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

            int index = 21;

            string[] lines = dataSeed.Split(Environment.NewLine);
            while(lines.Length > index + 5)
            {
                    var genre = lines[index].Split("<td>")[1].Split("</td>")[0];
                    var title = lines[index + 1].Split("<td>")[1].Split("</td>")[0];
                    var author = lines[index + 2].Split("<td>")[1].Split("</td>")[0];

                    var booksSoldText = lines[index + 3].Split("<td>")[1].Split("</td>")[0];
                    var booksSold = 0;
                    if (booksSoldText.ToLower().Contains("million"))
                    {
                        booksSold = Convert.ToInt32(booksSoldText.Split(" ")[0]) * 1000000;
                    }
                    else if (booksSoldText.ToLower().Contains("billion"))
                    {
                        booksSold = Convert.ToInt32(Convert.ToDouble(booksSoldText.Split(" ")[0]) * 1000000000);
                    }

                    var quantityText = lines[index + 4].Split("<td>")[1].Split("</td>")[0];
                    int? quantity = null;
                    if (!quantityText.Equals("-"))
                    {
                        quantity = Convert.ToInt32(quantityText);
                    }

                    string priceText1 = lines[index + 5].Replace(" ", "" ).Split("<td>")[1].Split("</td>")[0];
                    string priceText2 = lines[index + 6].Replace(" ", "" ).Split("<td>")[1].Split("</td>")[0];
                    string priceText3 = lines[index + 7].Replace(" ", "" ).Split("<td>")[1].Split("</td>")[0];
                    string priceText4 = lines[index + 8].Replace(" ", "" ).Split("<td>")[1].Split("</td>")[0];

                    books[EBookType.EBook].Add(new EBook(genre, title, author, booksSold, quantity, GetPrice(priceText1)));
                    books[EBookType.AudioBook].Add(new AudioBook(genre, title, author, booksSold, quantity, GetPrice(priceText2)));
                    books[EBookType.HardcoverBook].Add(new HardcoverBook(genre, title, author, booksSold, quantity, GetPrice(priceText3)));
                    books[EBookType.PaperbackBook].Add(new PaperbackBook(genre, title, author, booksSold, quantity, GetPrice(priceText4)));

                    index = index + 11;                               
            }

            return books;
        }

        public string Encode(Dictionary<EBookType, List<Book>> book)
        {
            throw new NotImplementedException();
        }


        private double? GetPrice(string priceText)
        {          
            if(priceText.Contains("EUR")) { return Convert.ToDouble(priceText.Split("EUR")[0]); }
            if(priceText.Contains("$")) { return Convert.ToDouble(priceText.Replace("$", "")[0].ToString()) * 1; }
            if(priceText.Contains("PLN")) { return Convert.ToDouble(priceText.Split("PLN")[0]) * 0.21; }

            return null;
        }
    }
}
