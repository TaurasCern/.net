using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace ToDoApi.Database
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {
        
        }
        public ApiContext()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoNote> ToDoNotes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=ToDoApi.db");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.UserId);
            modelBuilder.Entity<User>().Property(u => u.UserId).HasColumnName("UserId");
            modelBuilder.Entity<User>().HasMany(u => u.ToDoNotes);

            modelBuilder.Entity<ToDoNote>().HasKey(n => n.NoteId);
            modelBuilder.Entity<ToDoNote>().Property(n => n.NoteId).HasColumnName("NoteId");
            modelBuilder.Entity<ToDoNote>().HasOne(n => n.User);
        }
    }
}
