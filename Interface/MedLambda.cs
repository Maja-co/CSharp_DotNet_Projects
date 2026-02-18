namespace Interface;

public class MedLambda {
    public static void UdfoerLambdaSortering(List<Person> liste) {
        // 1. Sorter efter navn og udskriv
        liste.Sort((x, y) => x.Name.CompareTo(y.Name));
        Console.WriteLine("Sorteret efter navn:");
        foreach (var p in liste) Console.WriteLine(p);

        // 2. Sorter efter alder og udskriv
        liste.Sort((x, y) => x.Age.CompareTo(y.Age));
        Console.WriteLine("\nSorteret efter alder:");
        foreach (var p in liste) Console.WriteLine(p);

        // 3. Sorter efter vægt og udskriv
        liste.Sort((x, y) => x.Weight.CompareTo(y.Weight));
        Console.WriteLine("\nSorteret efter vægt:");
        foreach (var p in liste) Console.WriteLine(p);
    }
}