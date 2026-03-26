using Microsoft.AspNetCore.Mvc;
using PersonWebAPI.Models;

namespace PersonWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase {
    private static List<Person> _personer = new List<Person> {
        new Person("Anders", "And", 1),
        new Person("Micky", "Mouse", 2)
    };

    [HttpGet]
    [Route("GetAll")]
    public IEnumerable<Person> GetAll() {
        return _personer;
    }

    [HttpGet]
    [Route("GetById/{id}")]
    public Person? GetPerson(int id) {
        return _personer.Find(p => p.Id == id);
    }

    [HttpPost]
    public ActionResult AddPerson(Person Person) {
        _personer.Add(Person);
        return CreatedAtAction(nameof(GetPerson), new { id = Person.Id }, Person);
    }
}