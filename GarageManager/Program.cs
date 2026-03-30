using GarageManager.Data;
using GarageManager.Models;
using Microsoft.EntityFrameworkCore;

// 1. DINE NYE DATA
List<Bil> mineNyeBiler = new List<Bil>() {
    new Bil("BMW", "iX", 2023, "El"),
    new Bil("Audi", "e-tron", 2022, "El"),
    new Bil("Skoda", "Enyaq", 2024, "El"),
    new Bil("Tesla", "Model 3", 2021, "El"),
    new Bil("BMW", "iX", 2023, "El")
};

using (GarageContext db = new GarageContext()) {
    // --- OPGAVE 11.3: RELATIONER (Sikrer at der er en ejer) ---
    var ejer = db.Ejere.FirstOrDefault();
    if (ejer == null) {
        ejer = new Ejer { Name = "Standard Ejer" };
        db.Ejere.Add(ejer);
        db.SaveChanges();
    }

    // --- DIN LOGIK: TILFØJ BILER (Med check for dubletter) ---
    foreach (Bil nyBil in mineNyeBiler) {
        if (db.Biler.Any(b => b.Brand == nyBil.Brand && b.Model == nyBil.Model && b.Year == nyBil.Year)) {
            Console.WriteLine($"Afvist: {nyBil.Brand} {nyBil.Model} findes allerede!");
        }
        else {
            nyBil.EjerId = ejer.Id; // Vi linker dynamisk til vores ejer
            db.Biler.Add(nyBil);
            Console.WriteLine($"Tilføjet: {nyBil.Brand} {nyBil.Model}");
        }
    }
    db.SaveChanges();
}

// --- DIN LOGIK: DYNAMISK OPRYDNING (Cleanup af dubletter) ---
using (var dbCleanup = new GarageContext()) {
    var dubletGrupper = dbCleanup.Biler
        .ToList()
        .GroupBy(b => new { b.Brand, b.Model, b.Year })
        .Where(g => g.Count() > 1);

    foreach (var gruppe in dubletGrupper) {
        var bilerDerSkalSlettes = gruppe.Skip(1).ToList();
        dbCleanup.Biler.RemoveRange(bilerDerSkalSlettes);
    }
    dbCleanup.SaveChanges();
    Console.WriteLine("--- Dynamisk oprydning fuldført! ---");
}

using (GarageContext db = new GarageContext()) {
    // --- OPGAVE 11.5: ÆNDRING AF DATA (Dynamisk Update & Delete) ---
    // Update: Vi tager den første Tesla vi finder og retter den
    var bilTilUpdate = db.Biler.FirstOrDefault(b => b.Brand == "Tesla");
    if (bilTilUpdate != null) {
        bilTilUpdate.Model += " (Opdateret)";
        db.SaveChanges();
    }
/*
    // Delete: Vi fjerner den allerførste bil i listen (uanset mærke)
    var bilToDelete = db.Biler.FirstOrDefault();
    if (bilToDelete != null) {
        db.Biler.Remove(bilToDelete);
        db.SaveChanges();
    }
*/
    // --- OPGAVE 11.6: MANGE-MANGE RELATION (Fly og Personer) ---
    var p1 = new Person { Navn = "Pilot 1" };
    var p2 = new Person { Navn = "Pilot 2" };
    var fly = new Fly { ModelNavn = "Boeing 747" };

    fly.Ejere.Add(p1);
    fly.Ejere.Add(p2);
    db.Flyvemaskiner.Add(fly);
    db.SaveChanges();

    // --- OPGAVE 11.4: VISNING (Viser alt med relationer) ---
    Console.WriteLine("\n--- ENDELIG STATUS ---");
    var biler = db.Biler.Include(b => b.Ejer).ToList();
    foreach (var bil in biler) {
        Console.WriteLine($"BIL: {bil.Brand} {bil.Model} - Ejer: {bil.Ejer.Name}");
    }

    var flyvemaskiner = db.Flyvemaskiner.Include(f => f.Ejere).ToList();
    foreach (var f in flyvemaskiner) {
        var ejere = string.Join(", ", f.Ejere.Select(e => e.Navn));
        Console.WriteLine($"FLY: {f.ModelNavn} - Medejere: {ejere}");
    }
}