// See https://aka.ms/new-console-template for more information

using MyLibrary;

List<Animal> animals = new List<Animal>();

Console.WriteLine("Hvilket dyr vil du oprette? (Skriv 'stop' for at afslutte)");


while (true)
{
    string input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }

    Animal aNewAnimal = new Animal(input);
    animals.Add(aNewAnimal);
}

Console.WriteLine("Du har oprettet følgende dyr:");
foreach (var animal in animals)
{
    Console.WriteLine(animal.Name);
}