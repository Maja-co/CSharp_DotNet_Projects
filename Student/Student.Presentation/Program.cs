using Microsoft.EntityFrameworkCore;
using Student.Business;
using Student.Data.Data;
using Student.Data.Models;
using Student.Data.Repository;

class Program {
    static async Task Main() {
        var options = ConfigureOptions();

        using var dbContext = new StudentContext(options);

        IStudentRepository repository = new StudentRepository(dbContext);
        var service = new StudentService(repository);

        // Opret en ny studerende
        var student = new StudentEntity { Name = "Maja", Age = 25 };
        await service.AddStudentAsync(student);

        // Hent alle
        var students = await service.GetAllStudentsAsync();
        Console.WriteLine("Alle studerende:");
        foreach (var s in students) {
            Console.WriteLine($"{s.StudentId}: {s.Name}, {s.Age} år");
        }

        // Opdater
        student.Name = "Maja K";
        await service.UpdateStudentAsync(student);

        // Slet
        await service.DeleteStudentAsync(student.StudentId);
    }

    public static DbContextOptions<StudentContext> ConfigureOptions() {
        var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");

        var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return optionsBuilder.Options;
    }
}