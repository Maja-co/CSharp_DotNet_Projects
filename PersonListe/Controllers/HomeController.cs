using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonListe.Models;

namespace PersonListe.Controllers;

public class HomeController : Controller {
    public IActionResult Index() {
        return View();
    }
    
    public IActionResult Person()
    {
        var personer = AllePersoner();
        return View(personer);
    }
    private List<Person> AllePersoner() {
        return new List<Person> {
            new Person { Name = "Maja", Surname = "Kragelund", Age = 25 },
            new Person { Name = "Jonas", Surname = "Hansen", Age = 32 },
            new Person { Name = "Anna", Surname = "Nielsen", Age = 19 }
        };
    }

    public IActionResult Privacy() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}