using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld2.Controllers
{
    [Route("/Products")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("{id}")]
        public IActionResult Detail(int id)
        {
            //Models.Product product = new Models.Product()
            //{
            //    Title = "Toilet Paper",
            //    Price = 1.99
            //};
            //return View(product);
            return Content("Product id# " + id);
        }

        [Route("/Products/Detalle")]
        [Route("/Gigasoft/Detalle")]
        public IActionResult DetailsViewData(int id)
        {
            ViewData["ProductTitle"] = "Toilet Paper";
            ViewBag.ProductPrice = 1.99;
            return View();
        }

        public IActionResult Products()
        {
            return View("/Views/Product/Products.cshtml");
        }
    }
}