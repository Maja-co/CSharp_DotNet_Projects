using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class RockbandsController : Controller
    {
        public IActionResult Index()
        {
            string[] rockbands = new string[10];
            rockbands[0] = "Led Zeppelin";
            rockbands[1] = "The Beatles";
            rockbands[2] = "Pink Floyd";
            rockbands[3] = "The Jimi Hendrix Experience";
            rockbands[4] = "Van Halen";
            rockbands[5] = "Queen";
            rockbands[6] = "The Eagles";
            rockbands[7] = "Metallica";
            rockbands[8] = "U2";
            rockbands[9] = "Bob Marley and the Wailers";

            ViewBag.Rockbands = rockbands;

            return View();
        }
    }
}