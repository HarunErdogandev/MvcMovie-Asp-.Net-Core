using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MovieWebUI.Controllers
{
    public class AdminController : Controller
    {
        public IMovieService _movieService;
        public AdminController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            var model=_movieService.GetAll().Data;
            return View(model);
        }
        public IActionResult AddMovie()
        {
            //Aktörler
            //Kategoriler
            //Yönetmen
            
            return View();
        }

        public IActionResult DeleteMovie() 
        {

            return View();
        }
    }
}
