using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace Lesson02_Startup.Controllers;

public class Exercise02Controller : Controller {
    public ActionResult IndexPerson() {
        // 1. Liste der indeholde 'Person'-objekter
        List<Person> personList = new List<Person>();

        // 2. Opret din person
        Person person2 = new Person("Harry", "Potter", "Hogwarts",  "9 3/4", "London");
        Person person3 = new Person("Bruce", "Wayne", "Wayne Manor", "1007", "Gotham");
        Person person4 = new Person("Frodo", "Baggins", "Bag End", "1", "Shire");
        Person person5 = new Person("Lara", "Croft", "Croft Manor", "123", "Surrey");
        Person person6 = new Person("Clark", "Kent", "Daily Planet", "344", "Metropolis");
        
        // 3. Tilføj personen til listen
        personList.Add(person2);
        personList.Add(person3);
        personList.Add(person4);
        personList.Add(person5);
        personList.Add(person6);
        
        // 4. Tilføjer tilefonnummer til listen
        person2.AddPhone("12345678");
        person2.AddPhone("87654321");
        
        // 5. Tilføjer fødselsdag
        person2.Birthday = new DateTime(1980, 7, 31);

        // 6. Hele listen gemt i et samlet ViewBag
        ViewBag.PeopleList = personList;

        return View();
    }
}