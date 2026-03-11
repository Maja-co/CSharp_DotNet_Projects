using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers {
    public class CalculatorController : Controller {
        [HttpGet]
        public IActionResult TimeCalculator() {
            return View();
        }

        [HttpPost]
        public IActionResult TimeCalculator(IFormCollection formCollection) {
            int hours = Convert.ToInt32(formCollection["Hours"]);
            int minutes = Convert.ToInt32(formCollection["Minutes"]);
            int seconds = Convert.ToInt32(formCollection["Seconds"]);

            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double total = ts.TotalSeconds;

            ViewBag.Hours = hours;
            ViewBag.Minutes = minutes;
            ViewBag.Seconds = seconds;
            ViewBag.Total = total;
            return View();
        }
    }
}