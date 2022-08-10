using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika.Models
{
    internal class Review
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            private set { email = value; }
        }
        private string review;

        public string Comment
        {
            get { return review; }
            private set { review = value; }
        }

        public Review(string name, string email, string comment) : this()
        {
            Name = name;
            Email = email;
            Comment = comment;
        }
        public Review()
        {
            this.Name = "";
            this.Email = "";
            this.Comment = "";
        }
        public override string ToString() => Name + ":" + Environment.NewLine + Comment;
    }
}
