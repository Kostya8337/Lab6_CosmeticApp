using Microsoft.EntityFrameworkCore;
using Lab6_CosmeticApp.Models;

namespace Lab6_CosmeticApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CosmeticProduct> CosmeticProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CosmeticAppDb;Trusted_Connection=True;");
        }
    }
}