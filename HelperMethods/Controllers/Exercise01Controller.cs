using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelperMethods.Controllers;

public class Exercise01Controller : Controller {
    // GET

    public IActionResult Index(string countries) {
        var list = GetCountries();
        var selected = list.FirstOrDefault(x => x.Value == countries);
        if (selected != null) {
            selected.Selected = true;
        }
        ViewBag.CountryList = list; 
        ViewBag.CountryCode = countries;
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(IFormCollection formData) {
        string newCountryName = formData["countryName"];
        string newCountryCode = formData["countryCode"];
        var countries = GetCountries();
        countries.Add(new SelectListItem {
            Text = newCountryName,
            Value = newCountryCode
        });

        ViewBag.Countries = countries;
        return View();
    }

    private List<SelectListItem> GetCountries() {
        return new List<SelectListItem> {
            new SelectListItem { Text = "China", Value = "CN" },
            new SelectListItem { Text = "Denmark", Value = "DK" },
            new SelectListItem { Text = "United Kingdom", Value = "UK" },
            new SelectListItem { Text = "Spain", Value = "ES" },
            new SelectListItem { Text = "Sweden", Value = "SE" },
            new SelectListItem { Text = "France", Value = "FR" },
            new SelectListItem { Text = "Italy", Value = "IT" },
            new SelectListItem { Text = "Netherlands", Value = "NL" },
            new SelectListItem { Text = "Japan", Value = "JP" }
        };
    }
}