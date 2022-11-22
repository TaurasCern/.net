using BookApi.Enums;
using BookApi.Interfaces;
using BookApi.Models.Concrete;

namespace BookApi.Services
{
    public class BookSet : IBookSet
    {
        private List<Book> books = new List<Book>()
        {
            new Book(1,"title1","author1", ECoverType.PaperBack,2000),
            new Book(2,"title2","author2", ECoverType.PaperBack,2000),
            new Book(3,"title3","author3", ECoverType.PaperBack,2000),
            new Book(4,"title4","author4", ECoverType.PaperBack,2000),
        };

        public List<Book> Books { get { return books; } set { books = value; } }
    }
}
