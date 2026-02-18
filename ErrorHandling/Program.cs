// Kald den normale metode fra Main

MyNormalMethod(10);

void MyNormalMethod(int num = 0) {
    Console.WriteLine("--- MyNormalMethod starter ---");

    try {
        Console.WriteLine("Forsøger at kalde MyMethodWithError...");
        MyMethodWithError(num);
        Console.WriteLine("Dette punkt nås aldrig, hvis der kastes en fejl.");
    }
    catch (Exception ex) {
        // Her fanges fejlen, der blev kastet i den anden metode
        Console.WriteLine($"FEJL FANGET: {ex.Message}");
    }
    finally {
        // Denne blok kører ALTID, uanset om der var fejl eller ej
        Console.WriteLine("Finally-blok: Her ryddes op eller afsluttes processen.");
    }

    Console.WriteLine("--- MyNormalMethod er færdig ---\n");
}

void MyMethodWithError(int num = 0) {
    Console.WriteLine($"MyMethodWithError modtog tallet: {num}");

    // Vi kaster en manuel fejl (exception)
    throw new Exception("Dette er en planlagt fejlbesked fra MyMethodWithError!");
}