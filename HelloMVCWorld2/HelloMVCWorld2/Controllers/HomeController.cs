using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVCWorld2.Controllers
{
    public class HomeController : Controller
    {
              // GET: /<controller>/
        public IActionResult Index()
        {
            Models.Movie movie = new Models.Movie()
            {
                Title = "El Padrino",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            return View(movie);
            //return Content("Hello MVC World 2.1 ...usando Controllers!");
        }
        public IActionResult Varias()
        {
            return View("/Views/LFM/MyPagina.cshtml");           
        } 

        public IActionResult About()
        {
            return View("/Views/About/Index.cshtml");
        }
    }
}
