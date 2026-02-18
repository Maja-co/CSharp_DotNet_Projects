namespace MyLibrary;

public class Animal : IAnimal {
    public string Name { get; set; }
    public Animal(string name) {
        Name = name;
    }

    public bool IsAlive() {
        return true;
    }
}