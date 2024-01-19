using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_Day2.Controllers
{
    public class AddNumbersController : Controller
    {
        [HttpGet]
        public IActionResult Add1()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add1(IFormCollection form) {

            int no1 = int.Parse(form["no1"]);
            int no2 = int.Parse(form["no2"]);
            int res=no1 + no2;
            ViewBag.res = res;
            //return Content(res.ToString());
            return View();
        }
    }
}
