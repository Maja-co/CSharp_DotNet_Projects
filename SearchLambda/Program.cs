class Program {
    static void Main(string[] args) {
        List<int> numbers = new List<int>();
        AddNumbers(numbers);
        Console.WriteLine($"Listen indeholder nu {numbers.Count} tal.");
        List<int> evenNumbers = numbers.FindAll(num => num % 2 == 0);
        evenNumbers.ForEach(num => Console.WriteLine(num));
        int numberOver = evenNumbers.Find(num => num > 15);
        Console.WriteLine(numberOver);
        int numberIndex = numbers.FindLastIndex(num => num > 15);
        Console.WriteLine(numberIndex);
    }

    static void AddNumbers(List<int> listen) {
        var rand = new Random();
        for (int i = 0; i < 30; i++) {
            int number = rand.Next(0, 30);
            listen.Add(number);
            Console.WriteLine(number);
        }
    }
}