

Console.WriteLine(4.Factorial());
Console.WriteLine(2.Power(4));

int tal = 4;
Console.WriteLine(tal.Factorial());
int grundtal = 2;
Console.WriteLine(grundtal.Power(3));

public static class IntegerExtensions {
    public static int Factorial(this int n) {
        if (n <= 1) return 1;
        return n * (n - 1).Factorial();
    }

    public static int Power(this int n, int p) {
        if (p <= 0) return 1;
        return n * n.Power(p - 1);
    }
}