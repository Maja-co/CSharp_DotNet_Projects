// See https://aka.ms/new-console-template for more information

while (true) {
    Console.WriteLine("Indtast nummeret på det højeste Fibonacci-tal (0 for at stoppe):");
    var input = Console.ReadLine();

    // TryParse returnerer en bool og lægger tallet ind i 'inputNumbers', hvis det lykkes
    if (!int.TryParse(input, out int inputNumbers)) {
        Console.WriteLine("Ugyldigt input! Indtast venligst et tal.");
        continue;
    }
    if (inputNumbers == 0) {
        break;
    }
    
    int[] numbers = new int[inputNumbers];

    for (int i = 0; i < numbers.Length; i++) {
        numbers[i] = calcFibonnaci(i);
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine("\n");
}

static int calcFibonnaci(int n) {
    if (n == 0) {
        return 0;
    }

    if (n == 1) {
        return 1;
    }

    return calcFibonnaci(n - 1) + calcFibonnaci(n - 2);
}