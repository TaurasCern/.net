using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryingSQLite.Domain.Models
{
    public class AuthorBlog
    {
        // many to many
        public int AuthorId { get; set; }
        public int BlogId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
