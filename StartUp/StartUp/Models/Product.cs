using System;

public class Product 
{
    private string name;
    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    private double price;
    public double Price 
    {
        get { return price; }
        set {
            if (value <= 0) {
                throw new Exception("Price is not accepted");
            }
            else {
                price = value;
            }
        }
    }

    private string imageUrl;
    public string ImageUrl 
    {
        get { return imageUrl; }
        set { imageUrl = value; }
    }
    
    public string Manufacturer { get; set; }
    
    public Product(string name, double price, string manufacturer) 
    {
        Name = name;                 
        Price = price;
        Manufacturer = manufacturer;
    }
}