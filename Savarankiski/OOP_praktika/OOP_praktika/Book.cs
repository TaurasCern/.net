using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika
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
            set { reviews = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int PageCount
        {
            get { return pages.Length; }
        }

        public string[] Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Book()
        {
            this.name = "";
            this.description = "";
            this.pages = new string[0];
        }
        public Book(string name, string description, string[] pages, List<Review> reviews)
        {
            this.Name = name;
            this.Description = description;
            this.Pages = pages;
            this.Reviews = reviews;
        }
        public Book(Book book)
        {
            this.Name = book.Name;
            this.Description = book.Description;
            this.Pages = book.Pages;
            this.Reviews = book.reviews;
        }
        public override string ToString()
        {
            return String.Format("Title: {0}{1}{2}", this.Name, Environment.NewLine, this.Description);
        }
    }
}
