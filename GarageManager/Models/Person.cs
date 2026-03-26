namespace GarageManager.Models;

public class Person 
{
    public int Id { get; set; }
    public string Navn { get; set; }

    // En person kan eje andele i mange fly 
    public List<Fly> Fly { get; set; } = new List<Fly>();
}