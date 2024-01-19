using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_Day2.Models;

namespace MVC_Assignment_Day2.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Abhinav", Manager = "Sashi sir", Dept = "IT" },
                new Employee() { Id = 2, Name = "Animesh", Manager = "Sashi sir", Dept = "IT" },
                new Employee(){ Id = 3, Name = "Chirag", Manager = "Sashi sir", Dept = "IT" },
                new Employee(){ Id = 4, Name = "Saurav", Manager = "Sashi sir", Dept = "IT" }
        };
            return View(list);
        }

        public IActionResult Display()
        {
            Employee emp = new Employee()
            {
                Id=1,
                Name="Abhinav",
                Manager="Sashi",
                Dept="IT"
            };
            return View(emp);
        }
    }
}
