namespace Introduktion;

public class Person {
    private string name;
    
    public Person(string name) {
        this.name = name;
    }
    
    public string Name {
        get { return name; }
        set { name = value; }
    }
    
    public override string ToString() {
        return $"Name is {Name}";
    }
}