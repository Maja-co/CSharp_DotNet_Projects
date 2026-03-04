using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            int number1 = Convert.ToInt32(formCollection["Number1"]);
            int number2 = Convert.ToInt32(formCollection["Number2"]);
            string op = formCollection["operator"];
            double result = 0;

            switch (op)
            {
                case "+": result = number1 + number2; break;
                case "-": result = number1 - number2; break;
                case "*": result = number1 * number2; break;
                case "/":
                    if (number2 != 0)
                        result = (double)number1 / number2;
                    else
                        result = 0;
                    break;
            }

            ViewBag.Number1 = number1.ToString();
            ViewBag.Number2 = number2.ToString();
            ViewBag.Result = result;

            return View();
        }
    }
}