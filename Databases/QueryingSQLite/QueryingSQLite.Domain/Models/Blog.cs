using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryingSQLite.Domain.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        [Column(Order = 0)]
        public int BlogId { get; set; }
        [Column(Order = 2)]
        public decimal Rating { get; set; }
        [Column("BlogName", Order = 1)]
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual IList<AuthorBlog> AuthorBlogs { get; set; }
    }
}
