namespace GarageManager.Models;

public class Ejer
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<Bil> Biler { get; set; } = new List<Bil>();
}