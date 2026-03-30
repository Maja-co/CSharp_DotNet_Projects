using System;
using System.Collections.Generic;
using ListOfPeople;

public class FindAll {
    public static void Run() {
        string path = "/Users/majakragelund/Desktop/Datamatiker/C# & .NET/Selve kode/Introduktion/data1.csv";

        List<Person> people1 = Person.ReadCSVFile(path);
        Console.WriteLine($"Listen er hentet. Antal personer: {people1.Count}");

        // OPGAVE 1: Alle personer med en score under 2
        List<Person> lowScore = people1.FindAll(person => person.Score < 2);

        Console.WriteLine("\n--- Opgave 1: Score under 2 ---");
        foreach (var person in lowScore) {
            Console.WriteLine(person);
        }

        // OPGAVE 2: Alle personer med lige score (0, 2, 4...)
        List<Person> evenScore = people1.FindAll(person => person.Score % 2 == 0);

        Console.WriteLine("\n--- Opgave 2: Lige score ---");
        foreach (var person in evenScore) {
            Console.WriteLine(person);
        }

        // OPGAVE 3: Lige score OG vægt større end 60
        List<Person> evenAndHeavy = people1.FindAll(person => person.Score % 2 == 0 && person.Weight >= 60);

        Console.WriteLine("\n--- Opgave 3: Lige score og vejre mere end 60kg ---");
        foreach (var person in evenAndHeavy) {
            Console.WriteLine(person);
        }

        // OPGAVE 4: Vægt deleligt med 3
        List<Person> weightDiv3 = people1.FindAll(person => person.Weight % 3 == 0);

        Console.WriteLine("\n--- Opgave 4: Vægt kan deles med 3 ---");
        foreach (var person in weightDiv3) {
            Console.WriteLine(person);
        }
    }
}