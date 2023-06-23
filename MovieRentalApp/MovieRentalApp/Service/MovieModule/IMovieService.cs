using MovieRentalApp.Models;

namespace MovieRentalApp.Service.MovieModule
{
    public interface IMovieService
    {
        void AddMovie(Movie movie);

        void DeleteMovie(int  movieId);
        Movie GetMovieById(int movieId);
        void UpdateMovie(Movie  movie);

        List<Movie> GetAllMovie();

        List<Movie> GetMovieByMovieCategory(string cat);


    }
}
