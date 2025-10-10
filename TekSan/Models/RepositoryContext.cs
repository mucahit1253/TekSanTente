using Microsoft.EntityFrameworkCore;

namespace TekSan.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, CategoryId = 1, Name = "Pergole Tente", Slug = "pergole-tente", Price = 2000 },
                new Product() { Id = 2, CategoryId = 1, Name = "Körük Tente", Slug = "koruk-tente", Price = 2500 },
                new Product() { Id = 3, CategoryId = 1, Name = "Stor Tente", Slug = "stor-tente", Price = 1500 },
                new Product() { Id = 4, CategoryId = 1, Name = "Çift Açılır Tente", Slug = "cift-acılır-tente", Price = 5000 },
                new Product() { Id = 5, CategoryId = 1, Name = "Mafsallı Tente", Slug = "mafsalli-tente", Price = 30000 }

                );
        }
    }
}
