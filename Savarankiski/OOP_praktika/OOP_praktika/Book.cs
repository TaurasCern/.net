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
        private string[] pages;
        private List<Review> review;

        public List<Review> Reviews
        {
            get { return review; }
            set { review = value; }
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

        public Book(string name, string description, string[] pages)
        {
            this.Name = name;
            this.Description = description;
            this.Pages = pages;
        }
        public Book()
        {

        }
        public override string ToString()
        {
            return String.Format("Title: {0}{1}{2}", this.Name, Environment.NewLine, this.Description);
        }
    }
}
