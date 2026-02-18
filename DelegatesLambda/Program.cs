// See https://aka.ms/new-console-template for more information



string one = "Once Upon a Time In the West";
Boolean number = one.IsLongerThan(5);

Console.WriteLine("Number of words is more than 5: " + number);

Calculations.CalculateAndDisplay(10, 5, Calculations.Add);
Calculations.CalculateAndDisplay(10, 5, Calculations.Multiply);

public delegate int Operation(int a, int b);
public static class Calculations {
    public static void CalculateAndDisplay(int a, int b, Operation operation) {
        // 1. Udskriv a og b
        Console.WriteLine($"Input: a = {a}, b = {b}");

        // 2. Beregn og gem resultatet
        int calculateResult = operation(a, b);

        // 3. Udskriv resultatet
        Console.WriteLine($"Resultat: {calculateResult}");
    }

    public static int Add(int a, int b) => a + b;
    public static int Multiply(int a, int b) => a * b;
}

// Modtag en string og int, tjek antal ord, retuner true or false hvis string større end int
public static class StringExtension {
    public static bool IsLongerThan(this string str, int num) =>
        str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length > num;
}