using MyProject.Models;
using Microsoft.EntityFrameworkCore;


namespace CatalogService.Api.Data
{
    public class DataContext : DbContext
    {
        private DbContextOptions<DataContext> Options { get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Options = options;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Image>().ToTable("Image");
            modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Vendor>().ToTable("Vendor");
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
