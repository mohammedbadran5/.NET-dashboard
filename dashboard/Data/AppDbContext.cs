using dashboard.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using dashboard.Models; // Replace with your actual project namespace
namespace dashboard.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor that takes DbContextOptions and passes them to the base class
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet for your Card model (this represents your Cards table)
        public DbSet<Card> Cards { get; set; }

        // Optional: Override OnModelCreating if you need to customize the EF model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add any custom configurations (optional)
            modelBuilder.Entity<Card>().HasKey(c => c.Id); // Define primary key
        }
    }
}
