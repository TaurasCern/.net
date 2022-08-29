using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses.Domain.Enums;
using AbstractClasses.Domain.Models.Abstract;

namespace AbstractClasses.Domain.Interfaces
{
    public interface IBookHtmlService
    {
        Dictionary<EBookType, List<Book>> Decode(string dataSeed);
        string Encode(Dictionary<EBookType, List<Book>> book);
    }
}
