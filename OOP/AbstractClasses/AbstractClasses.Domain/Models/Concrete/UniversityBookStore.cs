using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Domain.Enums;
using AbstractClasses.Domain.Interfaces;
using AbstractClasses.Domain.Models.Abstract;

namespace AbstractClasses.Domain.Models.Concrete
{
    public class UniversityBookStore : IUniversityBookStore
    {
        public List<Book> Books { get; set; }
        public int Stock() => Books.Count;
        public string[] Genres()
        {
            string[] genres = new string[Books.Count];
            int arrIndex = 0;

            foreach (var book in Books)
            {
                if (!genres.Contains(book.Genre))
                {
                    genres[arrIndex] = book.Genre;
                    arrIndex++;
                }
            }

            return genres;
        }
        public void Buy(Book boughtBook, int qtty)
        {
            foreach(var book in Books)
            {
                if(book.Title.Equals(boughtBook.Title) && book.Type.Equals(boughtBook.Type))
                {
                    book.Quantity += qtty;
                }
                else
                {
                    Books.Add(book);
                }
            }
        }

        public void Fill(List<Book> dataSeed)
        {
            Books = dataSeed;
        }

        public AudioBook[] FilterAudioBooks(string? title)
        {
            var audioBooks = new AudioBook[Books.Count];
            var arrIndex = 0;

            foreach(var book in Books)
            {
                if(book.Type.Equals("AudioBook") && book.Title.Equals(title))
                {
                    audioBooks[arrIndex] = book as AudioBook;
                    arrIndex++;
                }
            }

            return audioBooks;
        }

        public List<EBook> FilterEBooks(string? title)
        {
            var eBooks = new List<EBook>();

            foreach (var book in Books)
            {
                if (book.Type.Equals("EBook") && book.Title.Equals(title))
                {
                    eBooks.Add(book as EBook);
                }
            }

            return eBooks;
        }

        public IEnumerable<PaperbackBook> FilterHarcoverBooks(string? title)
        {
            IEnumerable<PaperbackBook> paperbackBook = new List<PaperbackBook>();

            foreach (var book in Books)
            {
                if (book.Type.Equals("PaperbackBook") && book.Title.Equals(title))
                {
                    paperbackBook.Append(book as PaperbackBook);
                }
            }

            return paperbackBook;
        }

        public List<HardcoverBook> FilterPaperbackBooks(string? title)
        {
            var hardcoverBook = new List<HardcoverBook>();

            foreach (var book in Books)
            {
                if (book.Type.Equals("HardcoverBook") && book.Title.Equals(title))
                {
                    hardcoverBook.Add(book as HardcoverBook);
                }
            }

            return hardcoverBook;
        }

        public void Sale(Person person, string title, EBookType bookType, int qtty)
        {

            throw new NotImplementedException();
        }
    }
}
