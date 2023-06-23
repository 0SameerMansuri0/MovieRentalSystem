using MovieRentalApp.Context;
using MovieRentalApp.Models;
using System.Linq;

namespace MovieRentalApp.Repository.MovieModule
{
    
    public class MovieRepository : IMovieRepository
    {
        readonly AppDbContext _context;
        public MovieRepository(AppDbContext context)
        {
            _context =context;
        }

        public void AddMovieRepo(Movie movie)
        {
            if(movie!=null)
            _context.Add(movie);
            _context.SaveChanges();
           
        }

        public void DeleteMovieRepo(int movieId)
        {
           Movie movie= _context.Movies.FirstOrDefault(u => u.MovieId == movieId);

            if (movie != null)
            {
                _context.Remove(movie);
            }
        }

        public List<Movie> GetAllMovieRepo()
        {
            List<Movie> m=_context.Movies.ToList();
            return m;
        }

        public Movie GetMovieByIdRepo(int movieId)
        {
           return _context.Movies.FirstOrDefault(u=>u.MovieId==movieId);
        }

        public List<Movie> GetMovieByMovieCategoryRepo(string cat)
        {
            List<Movie> list=_context.Movies.Where(u=>u.MovieCategory==cat).ToList();
            return list;
        }

        public void UpdateMovieRepo(Movie movie)
        {
           Movie m= _context.Movies.FirstOrDefault(u => u.MovieId == movie.MovieId);
            _context.Remove(m);
            _context.Add(movie);
            _context.SaveChanges();

            

          
        }
    }
}
