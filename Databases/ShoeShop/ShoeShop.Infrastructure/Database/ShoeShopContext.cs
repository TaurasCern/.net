using Microsoft.EntityFrameworkCore;
using ShoeShop.Domain;
using ShoeShop.Infrastructure.Database.InitialData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Infrastructure.Database
{
    public class ShoeShopContext : DbContext
    {
        public ShoeShopContext(DbContextOptions options) : base(options)
        {

        }
        public ShoeShopContext()
        {

        }

        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<ShoeSize> ShoeSizes { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) //reikalinga testams
            {
                optionsBuilder.UseSqlite(@"Data Source=ShoeShop.db");
                optionsBuilder.UseLazyLoadingProxies(); /* Užtikriname kad EF palaikytu lazy loading instaliuojam package Microsoft.EntityFrameworkCore.Proxies */
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoeSize>().HasKey(k => k.Id);
            modelBuilder.Entity<ShoeSize>().Property(p => p.Id).HasColumnName("ShoeSizeId");
            modelBuilder.Entity<ShoeSize>()
                .HasOne(o => o.Shoe)
                .WithMany(m => m.Sizes)
                .HasForeignKey(f => f.ShoeId);
                     // arba
           // modelBuilder.Entity<Shoe>()
           //     .HasMany(m => m.Sizes)
           //     .WithOne(o => o.Shoe)
           //     .HasForeignKey(f => f.ShoeId);

            modelBuilder.Entity<Sale>()
                .HasOne(o => o.ShoeSize)
                .WithMany()
                .HasForeignKey(f => f.ShoeSizeId);

            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Shoe>().HasData(ShoeInitialdata.DataSeed);
            modelBuilder.Entity<ShoeSize>().HasData(ShoeSizeInitialData.DataSeed);
        }
    }
}
