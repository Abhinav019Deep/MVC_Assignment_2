using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_Day2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            ViewData["name"] = "Abhinav";
            ViewBag.address = "Delhi";
            return View();
        }

        public ViewResult Display() {
            return View();
        }

        public IActionResult Display1()
        {
            if (1 == 2)
            {
                return View();
            }
            else if (2 == 2)
            {
                return Content("Error");
            }
            else
                return RedirectToAction("Index");
        }

        public IActionResult Display2()
        {
            if (1 == 2)
            {
                return View();
            }
            else
                return RedirectToAction("Index");
        }

        public IActionResult Display3()
        {
            return View("index", "home"); // it will take us to index of home controller
        }
    }
}
