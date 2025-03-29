using Microsoft.EntityFrameworkCore;

namespace BooksCRUD.Models
{
    public class MyBookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("CONNECTION_STRING");
        }
    }
}
