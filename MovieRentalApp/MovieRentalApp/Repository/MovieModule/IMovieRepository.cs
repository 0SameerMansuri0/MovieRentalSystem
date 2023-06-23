using MovieRentalApp.Models;

namespace MovieRentalApp.Repository.MovieModule
{
    public interface IMovieRepository
    {
        void AddMovieRepo(Movie movie);

        void DeleteMovieRepo(int movieId);

        void UpdateMovieRepo(Movie movie);

        Movie GetMovieByIdRepo(int movieId);

        List<Movie> GetAllMovieRepo();

       List<Movie> GetMovieByMovieCategoryRepo(string cat);
    }
}
