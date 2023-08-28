using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieWebUI.Models;
using MovieWebUI.Models.Logger;

namespace MovieWebUI.Controllers
{
    public class AdminPanelController : Controller
    {
        public IMovieService _movieService;
        public IMovieDal _movieDal;
        public IDirectorService _directorService;

        public AdminPanelController(IMovieService movieService, IDirectorService directorService)
        {
            _directorService = directorService;
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            return View();

        }
        [HttpGet]
        public IActionResult MovieCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieCreate(Movie movie)
        {
            
            

            return View();
        }

        public IActionResult MovieUpdate(int movie)
        {

           
           
            


            return View();
        }
        [HttpPost]
        public IActionResult MovieUpdate(Movie movie)
        {

           

            return View();
        }

        public IActionResult Delete(int id)
        {
           
            return RedirectToAction("Index", "AdminPanel");


        }
    }
}
