using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Domain.Models.Concrete
{
    public static class ListOfBookHtmlExtensions
    {
        public static string ToHtml(this List<BookHtml> books)
        {

            string encodedHtml = @"
                <html>
                  <table>
                    <thead>
                      <tr>
                        <th rowspan=""2"">Genre</th>
                        <th rowspan=""2"">Title</th>
                        <th rowspan=""2"">Author</th>
                        <th rowspan=""2"">Books sold</th>
                        <th rowspan=""2"">Qtty</th>
                        <th colspan=""4"">Price</th>
                      </tr>
                      <tr>
                        <th>E-Eook</th>
                        <th>Audio</th>
                        <th>Hardcover</th>
                        <th>Paperback</th>
                      </tr>
                    </thead>
                    <tbody>";

            foreach (BookHtml book in books)
            {
                encodedHtml += $"                      <tr>";
                encodedHtml += $"{Environment.NewLine}                         <td>{book.Genre}</td>";
                encodedHtml += $"{Environment.NewLine}                         <td>{book.Title}</td>";
                encodedHtml += $"{Environment.NewLine}                         <td>{book.Author}</td>";
                encodedHtml += $"{Environment.NewLine}                         <td>{book.BooksSold}</td>";
                encodedHtml += $"{Environment.NewLine}                         <td>{book.Quantity}</td>";
                encodedHtml += $"{Environment.NewLine}                         <td>{EncodePrice(book.EBookPrice)}</td>";
                encodedHtml += $"{Environment.NewLine}                         <td>{EncodePrice(book.AudioBookPrice)}</td>";
                encodedHtml += $"{Environment.NewLine}                         <td>{EncodePrice(book.HardcoverBookPrice)}</td>";
                encodedHtml += $"{Environment.NewLine}                         <td>{EncodePrice(book.PaperbackBookPrice)}</td>";
                encodedHtml += $"{Environment.NewLine}                      </tr>{Environment.NewLine}";
            }

            encodedHtml += $"                    </tbody{Environment.NewLine}                  </table>{Environment.NewLine}                </html>{Environment.NewLine}                ";

            return encodedHtml;
        }
        private static string EncodePrice(double? price)
        {
            if (price == null)
            {
                return "-";
            }
            return price + " EUR";
        }
    }
}
