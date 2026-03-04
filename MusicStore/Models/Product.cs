using System;

public class Product 
{
    private string title;
    public string Title 
    {
        get { return title; }
        set { title = value; }
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
    
    public Product(string title, double price, string manufacturer) 
    {
        Title = title;                 
        Price = price;
        Manufacturer = manufacturer;
    }

    public Product(string title, double price) {
        this.title = title;
        this.price = price;
    }
}