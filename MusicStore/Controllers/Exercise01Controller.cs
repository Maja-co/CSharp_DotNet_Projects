using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers;

public class Exercise01Controller : Controller {
    // GET
    public IActionResult Index() {
        var myBook = new Book("C# for Beginners", 299.95, "Tech Books") {
            Author = "Jane Doe",
            ISBN = "1234567890",
            Publisher = "IT-Forlaget"
        };

        // 1. Opret CD'en med basis-info (bruger den lille konstruktør)
        var myCd = new MusicCD("Abbey Road", 128.00, "Apple Records");

        // 2. Sæt de specifikke CD-ting
        myCd.Artist = "The Beatles";
        myCd.Label = "EMI";
        myCd.Released = 2009;

        // 3. Tilføj sange en efter en
        myCd.AddTrack("Come Together", "2:59");
        myCd.AddTrack("Something", "3:46");
        myCd.AddTrack("Maxwell's Silver Hammer", "1:29");

        // Send til view
        var products = new List<Product> { myBook, myCd };
        return View(products);
    }
}