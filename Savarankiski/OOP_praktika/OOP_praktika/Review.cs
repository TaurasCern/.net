using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika
{
    internal class Review
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string review;

        public string Comment
        {
            get { return review; }
            set { review = value; }
        }

        public Review(string name, string email, string comment)
        {
            this.Name = name;
            this.Email = email;
            this.Comment = comment;
        }
        public Review()
        {

        }
        public override string ToString() => this.Name + ":" + Environment.NewLine + this.Comment;
    }
}
