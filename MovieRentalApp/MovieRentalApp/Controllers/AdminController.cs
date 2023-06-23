using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieRentalApp.Constants;
using MovieRentalApp.Context;
using MovieRentalApp.Models;
using MovieRentalApp.Service.MovieModule;

namespace MovieRentalApp.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class AdminController : Controller
    {
        private readonly IMovieService _movieservice;
        private readonly ILogger<AdminController> _logger;

        public AdminController(IMovieService context, ILogger<AdminController> logger)
        {
            _movieservice= context;
            _logger = logger;
        }

        

        // GET: Admin
        public async Task<IActionResult> Index()
        {
           List<Movie> movie= _movieservice.GetAllMovie();
              return View(movie);
        }

        // GET: Admin/Details/5
        public  IActionResult Details(int id)
        {

            var movie =  _movieservice.GetMovieById(id);
                

            return View(movie);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieservice.AddMovie(movie);
               
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Admin/Edit/5
        public IActionResult Edit(int id)
        {

            var movie=_movieservice.GetMovieById(id);
           
            return View(movie);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("MovieId,MovieName,MovieCategory,MovieRentPrice,ActorName,DirectorName,ImagePath")] Movie movie)
        {
            if (id != movie.MovieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                    _movieservice.UpdateMovie(movie);
                    
                
                
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Admin/Delete/5
        public IActionResult Delete(int id)
        {
            var movie = _movieservice.GetMovieById(id);
                
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _movieservice.GetMovieById(id);
            if (movie != null)
            {
                _movieservice.DeleteMovie(movie.MovieId);
            }
            
           
            return RedirectToAction(nameof(Index));
        }

       
    }
}
