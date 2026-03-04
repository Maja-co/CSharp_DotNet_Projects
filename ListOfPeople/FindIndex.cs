namespace ListOfPeople;

public class FindIndex {
    public static void Run() {
        string path = "/Users/majakragelund/Desktop/Datamatiker/C# & .NET/Selve kode/Introduktion/data1.csv";

        List<Person> people1 = Person.ReadCSVFile(path);
        Console.WriteLine($"Listen er hentet. Antal personer: {people1.Count}");

        // OPGAVE 1: Første person med en score på præcis 3
        int scoreOfThree = people1.FindIndex(person => person.Score == 3);
        if (scoreOfThree != -1) {
            Console.WriteLine("Den første person med en score på præcis 3 er:");
            Person fundetPerson = people1[scoreOfThree];
            Console.WriteLine(fundetPerson + "\n");
        }
        else {
            Console.WriteLine("Ingen person fundet med score 3.");
        }

        // OPGAVE 2: Første person som er under 10 år, med en score på 3
        int underTenYears = people1.FindIndex(person => person.Age < 10 && person.Score == 3);
        if (underTenYears != -1) {
            Console.WriteLine("Den første person som er under 10 år, med en score på 3:");
            Person fundetPerson = people1[underTenYears];
            Console.WriteLine(fundetPerson + "\n");
        }
        else {
            Console.WriteLine("Ingen person fundet under 10 år, med en score på 3.");
        }

        // OPGAVE 3: Alle personer som er under 10 år, med en score på 3
        List<Person> everyoneTenYears = people1.FindAll(person => person.Age < 10 && person.Score == 3);

        Console.WriteLine("Alle personer som er under 10 år, med en score på 3");
        foreach (var person in everyoneTenYears) {
            Console.WriteLine(person + "\n");
        }

        // OPGAVE 4: Første personer under 8 år, med en score på 3
        int underEightYears = people1.FindIndex(person => person.Age < 8 && person.Score == 3);
        if (underEightYears != -1) {
            Console.WriteLine("Den første personer under 8 år, med en score på 3:");
            Person fundetPerson = people1[underEightYears];
            Console.WriteLine(fundetPerson + "\n");
        }
        else {
            Console.WriteLine("Ingen person fundet under 8 år, med en score på 3");
        }
    }
}