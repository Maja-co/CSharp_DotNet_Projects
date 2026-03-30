using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sale.Models;

namespace Sale.Controllers;

public class HomeController : Controller {


    public IActionResult Sale() {
        return View();
    }

    public IActionResult MoreSales() {
        return View();
    }

}