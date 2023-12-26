using BlazorServerCrudNet8.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCrudNet8.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> opction) : base(opction)
        {
        }

        public DbSet<VideoGame> videoGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { 
                    Id= 1, 
                    Title = "Cyberpunk 2077", 
                    Publisher = "CD Projekt", 
                    ReleaseYear =  2020
                },
                new VideoGame
                {
                    Id = 2,
                    Title = "Elden Ring",
                    Publisher = "From Software",
                    ReleaseYear = 2022
                },
                new VideoGame
                {
                    Id = 3,
                    Title = "The Leyend of Zelda",
                    Publisher = "Nintendo",
                    ReleaseYear = 1998
                }




                );
        }

    }
}
