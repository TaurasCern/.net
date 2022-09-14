using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Intro.Infrastructure.Database
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData; // %LOCALAPPDATA%
            var path = Environment.GetFolderPath(folder);
            ConnectionString = Path.Join(path, "CodeFirstBlogging.db");
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public string ConnectionString { get; set; } // Db path
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={ConnectionString}");
            optionsBuilder.UseLazyLoadingProxies(); // Needs - Microsoft.EntityFrameworkCore.Proxies;
        }
    }
}
