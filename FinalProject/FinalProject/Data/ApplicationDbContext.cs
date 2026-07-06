using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
namespace FinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Album> Albums { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Album>().ToTable("Albums");

            modelBuilder.Entity<Album>().HasData(
             new Album
             {
                 Id = 1,
                 Name = "To Pimp a Butterfly",
                 Artist = "Kendrick Lamar",
                 Genre = "Hip Hop",
                 Description = "Kendrick Lamar's third studio album, released in 2015",
                 Type = "Vynil",
                 IsOwned = true,
                 Rating = 4,
             },
             new Album
             {
                 Id = 2,
                 Name = "Reise, Reise",
                 Artist = "Rammstein",
                 Genre = "Metal",
                 Description = "Rammstein's fourth studio album, released in 2004.",
                 Type = "CD",
                 IsOwned = false,
                 Rating = 5,
             }
         );
        }
    }
}
