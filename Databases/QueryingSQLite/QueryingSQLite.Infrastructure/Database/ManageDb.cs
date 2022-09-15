using QueryingSQLite.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryingSQLite.Infrastructure.Database
{
    public class ManageDb
    {
        public ManageDb()
        {
            using var context = new BloggingContext();
            context.Database.EnsureCreated();
        }

        public void AddBlog(string name)
        {
            using var context = new BloggingContext();
            context.Blogs.Add(new Blog() { Name = name });
            context.SaveChanges();
        }
        public void AddPost(string title, int blogId)
        {
            var context = new BloggingContext();
            var blog = context.Blogs.Find(blogId);
            blog.Posts.Add(new Post() { Title = title});
            context.SaveChanges();
        }
        public void AddAuthor(string firstName, string lastName, int blogId)
        {
            var context = new BloggingContext();
            context.AuthorBlogs.Add(
                new AuthorBlog
                {
                    Author = new Author
                    {
                        FirstName = firstName,
                        LastName = lastName
                    },
                    BlogId = blogId
                });
            context.SaveChanges();
        }
    }
}
