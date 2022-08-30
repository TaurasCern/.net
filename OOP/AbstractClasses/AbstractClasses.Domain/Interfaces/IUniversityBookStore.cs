using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Domain.Models.Concrete;
using AbstractClasses.Domain.Models.Abstract;
using AbstractClasses.Domain.Enums;

namespace AbstractClasses.Domain.Interfaces
{
    public interface IUniversityBookStore
    {
        void Fill(List<Book> dataSeed);
        void Buy(Book book, int qtty);
        void Sale(Person person, string title, EBookType bookType, int qtty);
        List<EBook> FilterEBooks(string? title);
        AudioBook[] FilterAudioBooks(string? title);
        IEnumerable<PaperbackBook> FilterHarcoverBooks(string? title);
        List<HardcoverBook> FilterPaperbackBooks(string? title);
    }
}
