using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MovieWebUI.Models;

namespace MovieWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

       
    }
}
