using Microsoft.EntityFrameworkCore;
using Movie_SlutProjekt.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Movie_SlutProjekt.Context
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<MovieModel> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<MovieModel>().HasData(

            new MovieModel { Id = 1, Title = "The Shawshank Redemption", Director = "Frank Darabont", Year = 1994, Genre = "Drama", Duration = 142, Rating = 9.3 },
            new MovieModel { Id = 2, Title = "The Godfather", Director = "Francis Ford Coppola", Year = 1972, Genre = "Crime, Drama", Duration = 175, Rating = 9.2 },
            new MovieModel { Id = 3, Title = "The Dark Knight", Director = "Christopher Nolan", Year = 2008, Genre = "Action, Crime, Drama", Duration = 152, Rating = 9.0 },
            new MovieModel { Id = 4, Title = "Pulp Fiction", Director = "Quentin Tarantino", Year = 1994, Genre = "Crime, Drama", Duration = 154, Rating = 8.9 },
            new MovieModel { Id = 5, Title = "Fight Club", Director = "David Fincher", Year = 1999, Genre = "Drama", Duration = 139, Rating = 8.8 },
            new MovieModel { Id = 6, Title = "Forrest Gump", Director = "Robert Zemeckis", Year = 1994, Genre = "Drama, Romance", Duration = 142, Rating = 8.8 },
            new MovieModel { Id = 7, Title = "Inception", Director = "Christopher Nolan", Year = 2010, Genre = "Action, Adventure, Sci-Fi", Duration = 148, Rating = 8.7 },
            new MovieModel { Id = 8, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", Year = 1999, Genre = "Action, Sci-Fi", Duration = 136, Rating = 8.7 },
            new MovieModel { Id = 9, Title = "Interstellar", Director = "Christopher Nolan", Year = 2014, Genre = "Adventure, Drama, Sci-Fi", Duration = 169, Rating = 8.6 },
            new MovieModel { Id = 10, Title = "The Lord of the Rings: The Fellowship of the Ring", Director = "Peter Jackson", Year = 2001, Genre = "Adventure, Drama, Fantasy", Duration = 178, Rating = 8.8 });

        }
    }
}
