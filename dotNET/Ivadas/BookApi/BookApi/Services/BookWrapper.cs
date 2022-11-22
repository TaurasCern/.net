using BookApi.Enums;
using BookApi.Interfaces;
using BookApi.Models.Concrete;
using BookApi.Models.DTOs;

namespace BookApi.Services
{
    public class BookWrapper : IBookWrapper
    {
        public GetBookDTO Bind(Book book) => new()            
        {  
            Id = book.Id, 
            PavadinimasIrAutorius = $"{book.Title},{book.Author}", 
            LeidybosMetai = book.ReleaseYear 
        };

        public Book Bind(CreateBookDTO book) => new()       
        {
            Title = book.Pavadinimas,
            Author = book.Autorius,
            Cover = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
            ReleaseYear = book.Isleista.Year
        };

        public Book Bind(UpdateBookDTO book) => new()           
        {
            Id = book.Id,
            Title = book.Pavadinimas,
            Author = book.Autorius,
            Cover = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
            ReleaseYear = book.Isleista.Year
        };
    }
}