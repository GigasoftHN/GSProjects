using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMVCWorld2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld2.Controllers
{
    public class WebUserController : Controller
    {   
        [HttpGet]
        public IActionResult SimpleBinding()
        {
            return View(new WebUser() { FirstName = "John", LastName = "Doe" });
        }

        [HttpPost]
        public IActionResult SimpleBinding(WebUser webUser)
        {
            //TODO: Update in DB here...
            return Content($"Usuario {webUser.FirstName} Actualizado!");
        }

        [HttpGet]
        public IActionResult SimpleValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleValidation(WebUser webUser)
        {
            if (ModelState.IsValid)
                return Content("Thank you!");
            else
                //return Content("Model could not be validated!");
                return View(webUser);
        }

    }
}