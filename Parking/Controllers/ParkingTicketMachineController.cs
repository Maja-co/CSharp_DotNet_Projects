using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Parking.Models;

namespace Parking.Controllers;

public class ParkingTicketMachineController : Controller {
    // GET
    public IActionResult Index() {
        var ptm = new ParkingTicketMachine();
        return View(ptm);
    }

    [HttpPost]
    public IActionResult Index(IFormCollection formData) {
        var ptm = new ParkingTicketMachine();
        int amount = 0;
        if (formData["amountInserted"] != StringValues.Empty) {
            amount = int.Parse(formData["amountInserted"]);
        }

        ptm.InsertCoin(amount);
        if (formData["1"] != StringValues.Empty) {
            ptm.InsertCoin(1);
        }

        if (formData["2"] != StringValues.Empty) {
            ptm.InsertCoin(2);
        }

        if (formData["5"] != StringValues.Empty) {
            ptm.InsertCoin(5);
        }

        if (formData["10"] != StringValues.Empty) {
            ptm.InsertCoin(10);
        }

        if (formData["20"] != StringValues.Empty) {
            ptm.InsertCoin(20);
        }

        if (formData["confirm"] != StringValues.Empty) {
            return View("Confirm", ptm);
        }

        if (formData["cancel"] != StringValues.Empty) {
            ViewBag.Info = $"{amount} kr is paid back";
            ptm = new ParkingTicketMachine();
        }

        return View(ptm);
    }
}