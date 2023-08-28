using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using MovieWebUI.Models;
using System.Linq;

namespace MovieWebUI.Controllers
{
    public class MovieController : Controller
    {
        private IMovieService _movieService;
        private IMovieDal _movieDal;
        public MovieController(IMovieService movieService, IMovieDal movieDal)
        {
            _movieService = movieService;
            _movieDal = movieDal;
        }

        public IActionResult Index()
        {
            var Model = new MovieListViewModel
            {
               
                Movies = _movieService.GetAll(),
                RandomMovies = _movieService.GetRandomMovies(),
            };
            
            
           return View(Model);
        }

        public IActionResult Movies(int category,string search)
        {
            var Model = new MovieListViewModel
            {
                MovieGenres = _movieService.GetByCategory(category),
                Movies =search !=null? _movieService.GetSearchMovie(search):_movieService.GetAll(),
                
            };
            return View(Model);
        }

        public IActionResult Detail(int detail)
        {
            var Model = new MovieDetailListView
            {
                GetMovie = _movieService.GetMovie(detail),
                Actors = _movieService.GetByActor(detail),
                Directors = _movieService.GetByDirector(detail),
                MovieCategories = _movieService.GetMovieCategory(detail),
            };

            return View(Model);
        }

        
    }
}
