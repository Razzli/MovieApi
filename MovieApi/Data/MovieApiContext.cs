using Microsoft.EntityFrameworkCore;

public class MovieApiContext(DbContextOptions<MovieApiContext> options) : DbContext(options)
{
    public DbSet<MovieApi.Models.Movie> Movie { get; set; } = default!;
    public DbSet<MovieApi.Models.Actor> Actor { get; set; } = default!;
    public DbSet<MovieApi.Models.Review> Review { get; set; } = default!;
}
