using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Data
{
    public class MovieApiContext(DbContextOptions<MovieApiContext> options) : DbContext(options)
    {
        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<MovieDetails> MovieDetails { get; set; } = default!;
        public DbSet<Genre> Genre { get; set; } = default!;
        public DbSet<Actor> Actor { get; set; } = default!;
        public DbSet<Review> Review { get; set; } = default!;
    }
}
