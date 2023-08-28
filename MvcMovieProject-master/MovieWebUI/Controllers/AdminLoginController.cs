using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace MovieWebUI.Controllers
{
    public class AdminLoginController : Controller
    {
        MovieDbContext context = MovieDbContext.Instance;

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            var result=context.Admins.FirstOrDefault(x=>x.UserName==admin.UserName && x.Password==admin.Password);

            if (result!=null) 
            {
                return RedirectToAction("Index", "AdminPanel");
            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı";
            }
            return View();
        }
    }
}
