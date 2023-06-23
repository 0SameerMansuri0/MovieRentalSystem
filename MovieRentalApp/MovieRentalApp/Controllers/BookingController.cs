using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using MovieRentalApp.Constants;
using MovieRentalApp.Context;
using MovieRentalApp.Models;
using MovieRentalApp.Repository.MovieModule;

namespace MovieRentalApp.Controllers
{
    public class BookingController : Controller
    {
        readonly AppDbContext _context;
        readonly IMemoryCache _cache;
        private readonly UserManager<User> _userManager;
        readonly SignInManager<User> _signInManager;

        public BookingController(AppDbContext context, IMemoryCache cache, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _cache = cache;
            _userManager = userManager;
            _signInManager = signInManager;

        }



        public IActionResult Index(string categoryFilter)
        {
            string cacheKey = "MovieList";

            if (!_cache.TryGetValue(cacheKey, out IEnumerable<Movie> movies))
            {
                movies = _context.Movies.ToList();

                // Set the cache entry with a sliding expiration of 1 hour
                _cache.Set(cacheKey, movies, TimeSpan.FromHours(1));
            }

            if (!string.IsNullOrEmpty(categoryFilter))
            {
                movies = movies.Where(m => m.MovieCategory == categoryFilter);
            }

            return View(movies);
        }

        public IActionResult BookMovie(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            return View(movie);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> BookMovie(Movie movie)
        {

            

            

            
            Bookiing book = new Bookiing();
            book.userId = _userManager.GetUserId(User);
            book.movieId = movie.MovieId;
            book.movieName = movie.MovieName;
            book.moviePrice = movie.MovieRentPrice;
            if (ModelState.IsValid)
            {
                _context.bookiings.Add(book);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return StatusCode(404,"Booking object Not found");
        }
        [Authorize]
        public ActionResult GetMyMovie(string  id)
        {
            List<Bookiing> list = _context.bookiings.Include(m => m.user).Where(u => u.userId == id).ToList();
            return View(list);
        }
        public IActionResult Delete(int id)
        {
            Bookiing book = _context.bookiings.Find(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(Bookiing book)
        {
            _context.bookiings.Remove(book);
            return RedirectToAction("GetMyMovie");
        }



    }
}
