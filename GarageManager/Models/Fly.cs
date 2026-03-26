namespace GarageManager.Models;

public class Fly 
{
    public int Id { get; set; }
    public string ModelNavn { get; set; }

    // Et fly kan ejes af mange personer 
    public List<Person> Ejere { get; set; } = new List<Person>();
}