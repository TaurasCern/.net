using BookApi.Models.Concrete;
using BookApi.Models.DTOs;

namespace BookApi.Interfaces
{
    public interface IBookWrapper
    {
        GetBookDTO Bind(Book book);
        Book Bind(CreateBookDTO book);
        Book Bind(UpdateBookDTO book);
    }
}
