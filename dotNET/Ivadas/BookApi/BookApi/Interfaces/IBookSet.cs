using BookApi.Models.Concrete;

namespace BookApi.Interfaces
{
    public interface IBookSet
    {
        List<Book> Books { get; set; } 
    }
}
