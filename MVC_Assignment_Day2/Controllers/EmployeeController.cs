using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_Day2.Models;

namespace MVC_Assignment_Day2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.EmployeeId = 1;
            //ViewBag.Name = "Abhinav";

            Employee employee = new Employee()
            { Id = 1, Name = "Abhinav", Manager = "Sashi sir", Dept = "IT" };
            ViewBag.employee = employee;
            return View();
        }

        //if we want to pass multiple records
        public IActionResult List() {

            List<Employee> list = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Abhinav", Manager = "Sashi sir", Dept = "IT" },
                new Employee() { Id = 2, Name = "Animesh", Manager = "Sashi sir", Dept = "IT" },
                new Employee(){ Id = 3, Name = "Chirag", Manager = "Sashi sir", Dept = "IT" },
                new Employee(){ Id = 4, Name = "Saurav", Manager = "Sashi sir", Dept = "IT" }
        };
        ViewBag.list = list;
            return View();
        }
    }
}
