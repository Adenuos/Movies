using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_SlutProjekt.Context;
using Movie_SlutProjekt.Models;

namespace Movie_SlutProjekt.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : Controller
    {

        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }



        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] MovieModel movie)
        {
            if (movie == null)
            {
                return BadRequest("Invalid data.");
            }

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieById", new { id = movie.Id }, movie);
        }
        // GET: MoviesController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieModel>>> GetAllMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieModel>> GetMovieById(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, [FromBody] MovieModel updatedMovie)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            // Update the movie properties here
            movie.Title = updatedMovie.Title;
            movie.Director = updatedMovie.Director;
            movie.Year = updatedMovie.Year;
            movie.Genre = updatedMovie.Genre;
            movie.Duration = updatedMovie.Duration;
            movie.Rating = updatedMovie.Rating;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
