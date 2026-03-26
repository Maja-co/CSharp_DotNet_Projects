namespace GarageManager.Models;

public class Bil {
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Fuel { get; set; }
    public int EjerId { get; set; }
    public Ejer Ejer { get; set; }

    public Bil() {
    }

    public Bil(string brand, string model, int year, string fuel) {
        Brand = brand;
        Model = model;
        Year = year;
        Fuel = fuel;
    }
    
}