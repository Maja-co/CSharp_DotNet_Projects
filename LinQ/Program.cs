class Program {
    static void Main(string[] args) {
        List<int> numbers = new List<int>();
        AddNumbers(numbers);
        Console.WriteLine($"\nListen indeholder nu {numbers.Count} tal totalt.");
        Console.WriteLine("--------------------------------------------------");
        // Find alle lige tal (Query Expression / SQL-stil)
        Console.WriteLine("\n--- Query Expression: Alle lige tal (sorteret) ---");
        
        var queryExpression = from num in numbers
            where num % 2 == 0  
            orderby num         
            select num;         

        foreach (var num in queryExpression) {
            Console.WriteLine(num);
        }
        

        // Find to-cifrede tal (Query Expression / SQL-stil)

        Console.WriteLine("\n--- Query Expression: To-cifrede tal (sorteret) ---");

        var queryExpression2 = from num in numbers
            where num.ToString().Length == 2 // Konverterer til string og tjekker længden
            orderby num                      // Sorterer
            select num;
        
        foreach (var num in queryExpression2) {
            Console.WriteLine(num);
        }

        // Find alle lige tal (Query Method / Lambda)

        Console.WriteLine("\n--- Query Method: Alle lige tal (sorteret) ---");
        var queryMethod = numbers.Where(num => num % 2 == 0).OrderBy(num => num);
        
        foreach (var num in queryMethod) {
            Console.WriteLine(num);
        }
        
        Console.WriteLine("\n--- Query Method: To-cifrede tal (sorteret) ---");

        var queryMethod2 = numbers.Where(num => num.ToString().Length == 2).OrderBy(num => num);
        
        foreach (var num in queryMethod2) {
            Console.WriteLine(num);
        }
    }

    // Hjælpemetode til at generere tilfældige tal
    static void AddNumbers(List<int> listen) {
        var rand = new Random();
        Console.WriteLine("Genererer tal:");
        for (int i = 0; i < 30; i++) {
            int number = rand.Next(0, 30); 
            listen.Add(number);
            Console.Write(number + " "); 
        }
        Console.WriteLine(); 
    }
}