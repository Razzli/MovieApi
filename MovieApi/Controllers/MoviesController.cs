using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApi.DTOs;
using MovieApi.Models;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly MovieApiContext _context;
    public MoviesController(MovieApiContext context)
    {
        _context = context;
    }

    // GET: api/Movie
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieDTO>>> GetMovies()
    {
        var movieDTOs = (await _context.Movie.ToListAsync()).Select(
            Movie => new MovieDTO() 
            { 
                Id = Movie.Id,
                Title = Movie.Title,
                Year = Movie.Year,
                Duration = Movie.Duration
            }).ToList();
        return movieDTOs;
    }

    // GET: api/Movie/5
    [HttpGet("{id}")]
    public async Task<ActionResult<MovieDTO>> GetMovie(int id)
    {
        var movie = await _context.Movie.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }
        var movieDTO = new MovieDTO()
                        {
                            Id = movie.Id,
                            Title = movie.Title,
                            Year = movie.Year,
                            Duration = movie.Duration
                        };

        return movieDTO;
    }

    // GET: api/Movie/5/details
    [HttpGet("{id}/details")]
    public async Task<ActionResult<MovieDetails>> GetMovieDetails(int id)
    {
        var movie = await _context.Movie.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        return movie.MovieDetails;
    }

    // PUT: api/Movie/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutMovie(int? id, Movie movie)
    {
        if (id != movie.Id)
        {
            return BadRequest();
        }

        _context.Entry(movie).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MovieExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Movie
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<MovieDTO>> PostMovie(MovieCreateDTO movieCreateDTO)
    {
        var movie = new Movie("s", 1, 1);
        _context.Movie.Add(movie);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
    }
    
    // DELETE: api/Movie/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(int? id)
    {
        var movie = await _context.Movie.FindAsync(id);
        if (movie == null)
        {
            return NotFound();
        }

        _context.Movie.Remove(movie);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool MovieExists(int? id)
    {
        return _context.Movie.Any(e => e.Id == id);
    }
}
