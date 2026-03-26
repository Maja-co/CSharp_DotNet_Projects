using GarageManager.Models;
using Microsoft.EntityFrameworkCore;

namespace GarageManager.Data;

public class GarageContext : DbContext {
    // Opgave 11.1 & 11.3: En-til-mange relation [cite: 7, 22]
    public DbSet<Bil> Biler { get; set; }
    public DbSet<Ejer> Ejere { get; set; }

    // Opgave 11.6: Mange-til-mange relation 
    public DbSet<Fly> Flyvemaskiner { get; set; }
    public DbSet<Person> Personer { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        // Din eksisterende connection string [cite: 9]
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=GarageDatabase;User Id=GarageUser;Password=GaragePassword123!;Encrypt=False;");
    }
}