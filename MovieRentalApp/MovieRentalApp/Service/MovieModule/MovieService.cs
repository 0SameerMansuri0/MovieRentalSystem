using Microsoft.AspNetCore.Mvc.ModelBinding;
using MovieRentalApp.Context;
using MovieRentalApp.Models;
using MovieRentalApp.Repository.MovieModule;

namespace MovieRentalApp.Service.MovieModule
{
    public class MovieService : IMovieService
    {
        
        readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void AddMovie(Movie movie)
        {
           _movieRepository.AddMovieRepo(movie);
        }

        public void DeleteMovie(int movieId)
        {
            _movieRepository.DeleteMovieRepo(movieId);
        }

        public List<Movie> GetAllMovie()
        {
            List<Movie> movie=_movieRepository.GetAllMovieRepo(); 
                return movie;   
        }

        public Movie GetMovieById(int movieId)
        {
            return _movieRepository.GetMovieByIdRepo(movieId);
        }

        public List<Movie> GetMovieByMovieCategory(string cat)
        {
           return _movieRepository.GetMovieByMovieCategoryRepo(cat);
        }

        public void UpdateMovie(Movie movie)
        {
            _movieRepository.UpdateMovieRepo(movie);
        }

        
    }
}
