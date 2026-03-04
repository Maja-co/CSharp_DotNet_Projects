using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PersonModel person = new PersonModel();
            person.Name = "Anna";
            person.Age = 25;
            person.Birthday = new DateTime(1999, 3, 15);

            return View(person);
        }
    }
}