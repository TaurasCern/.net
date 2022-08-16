using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika.Models
{
    internal class Book
    {
        private string name;
        private string description;
        private string[] pages = Array.Empty<string>();
        private List<Review> reviews = new List<Review>();

        public List<Review> Reviews
        {
            get { return reviews; }
            private set { reviews = value; }
        }

        public string Description
        {
            get { return description; }
            private set { description = value; }
        }

        public int PageCount
        {
            get { return pages.Length; }
        }

        public string[] Pages
        {
            get { return pages; }
            private set { pages = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public Book()
        {
            name = "";
            description = "";
        }
        public Book(string name, string description, string[] pages, List<Review> reviews)
        {
            Name = name;
            Description = description;
            Pages = pages;
            Reviews = reviews;
        }
        public Book(Book book)
        {
            Name = book.Name;
            Description = book.Description;
            Pages = book.Pages;
            Reviews = book.reviews;
        }
        public override string ToString()
        {
            return string.Format("Title: {0}{1}{2}", Name, Environment.NewLine, Description);
        }
    }
}
