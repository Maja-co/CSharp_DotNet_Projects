using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {
        

        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50, "Imerco");
            glass.ImageUrl = "grandcru.jpg";
            ViewBag.Glass = glass;
			
            Product knife = new Product("Knife", 60.50, "Imerco");
            knife.ImageUrl = "grandcru.jpg";
            ViewBag.Knife = knife;
            
            Product bin = new Product("Bin", 260.50, "Imerco");
            bin.ImageUrl = "grandcru.jpg";
            ViewBag.Bin = bin;
            
            return View();
        }
        

    }
}
