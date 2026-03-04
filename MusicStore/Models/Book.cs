namespace MusicStore.Models;

public class Book : Product {
    public string Author { get; set; }
    public string Publisher { get; set; }
    public short Published { get; set; }
    public string ISBN { get; set; }
    public Book(string title, double price, string manufacturer) : base(title, price, manufacturer) {
    }

    public Book(string title, double price, string manufacturer, string author, string publisher, short published, string isbn) : base(title, price, manufacturer) {
        Author = author;
        Publisher = publisher;
        Published = published;
        ISBN = isbn;
    }

    public Book(string title, double price, string author, short published) : base(title, price) {
        Author = author;
        Published = published;
    }
}