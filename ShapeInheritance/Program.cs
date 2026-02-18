// Base class (Superklassen/Forælderen)

class Shape {
    public double X { get; set; }
    public double Y { get; set; }

    public Shape(double x, double y) {
        X = x;
        Y = y;
    }

    // Parameterløse constructor
    // THIS bruges til at kalde en anden constructor (^^) i samme klasse, så man undgår gentagelse af kode
    public Shape() : this(1, 1) {
    }
}

// Subclass (Underklassen/Barnet)
class Circle : Shape {
    public double Radius { get; set; }

    public Circle(double x, double y, double radius) : base(x, y) {
        Radius = radius;
    }
}

class Rectangle : Shape {
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double x, double y, double length, double width) : base(x, y) {
        Length = length;
        Width = width;
    }
}

class Program {
    static void Main(string[] args) {
        List<Shape> mineFormer = new List<Shape>();

        mineFormer.Add(new Circle(10, 10, 5.5));
        mineFormer.Add(new Rectangle(2, 5, 10.0, 20.0));

        foreach (Shape shapes in mineFormer) {
            Console.WriteLine($"Type: {shapes.GetType().Name} placeret ved X: {shapes.X}, Y: {shapes.Y}");

            if (shapes is Circle circkles) {
                Console.WriteLine($" - Radius er: {circkles.Radius}");
            }
        }
    }
}