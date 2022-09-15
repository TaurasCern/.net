using Microsoft.EntityFrameworkCore;
using QueryingSQLite.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryingSQLite.Infrastructure.Database
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnectionString = Path.Join(path, "QueryingBloggingDb.db");
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBlog> AuthorBlogs { get; set; }
        public string ConnectionString { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={ConnectionString}");
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBlog>()
                .HasKey(ab => new { ab.AuthorId, ab.BlogId });

            modelBuilder.Entity<AuthorBlog>()
                .HasOne<Author>(ab => ab.Author)
                .WithMany(ab => ab.AuthorBlog)
                .HasForeignKey(ab => ab.AuthorId);

            modelBuilder.Entity<AuthorBlog>()
                .HasOne<Blog>(ab => ab.Blog)
                .WithMany(ab => ab.AuthorBlogs)
                .HasForeignKey(ab => ab.BlogId);
        }
    }
}
