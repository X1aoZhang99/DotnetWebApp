using Microsoft.EntityFrameworkCore;
using RazerWebApp.Models;

namespace RazorWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fiction", DisplayOrder = "1" },
                new Category { Id = 2, Name = "Non-Fiction", DisplayOrder = "2" },
                new Category { Id = 3, Name = "Sci-Fi", DisplayOrder = "3" },
                new Category { Id = 4, Name = "Fantasy", DisplayOrder = "4" },
                new Category { Id = 5, Name = "Mystery", DisplayOrder = "5" },
                new Category { Id = 6, Name = "Thriller", DisplayOrder = "6" },
                new Category { Id = 7, Name = "Romance", DisplayOrder = "7" },
                new Category { Id = 8, Name = "Westerns", DisplayOrder = "8" },
                new Category { Id = 9, Name = "Dystopian", DisplayOrder = "9" },
                new Category { Id = 10, Name = "Contemporary", DisplayOrder = "10" }
                );
        }
    }
}
