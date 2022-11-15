using BookApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        List<Book> Books = new List<Book>()
            {
                new Book(1, "title1", "author1", 1990),
                new Book(2, "title2", "author2", 1990),
                new Book(3, "title3", "author2", 1990),
                new Book(4, "title4", "author2", 1990),
                new Book(5, "title5", "author3", 1990),
                new Book(6, "title6", "author4", 1990),
                new Book(7, "title7", "author5", 1990),
                new Book(8, "title8", "author6", 1990),
                new Book(9, "title9", "author7", 1990),
                new Book(10, "title10", "author8", 1990),
            };

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return Books;
        }
        [HttpGet("byId/{id}")]
        public Book? Get(int id)
        {
            return Books.Where(b => b.Id == id).FirstOrDefault();
        }
        [HttpGet("byTitle/{title}")]
        public Book? GetByTitle(string title)
        {
            return Books.Where(b => b.Title == title).FirstOrDefault();
        }
        [HttpGet("query1")]
        public IEnumerable<Book?> GetByAuthor(string author)
        {
            return Books.Where(b => b.Author == author);
        }
        [HttpGet("query2")]
        public IEnumerable<Book?> GetByTitleAndAuthor(string title, string author)
        {
            return Books.Where(b => b.Title.ToLower().Contains(title.ToLower()) && b.Author == author);
        }
    }
}
