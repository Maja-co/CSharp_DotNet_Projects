using Microsoft.EntityFrameworkCore.Design;
using Student.Data.Data;

namespace Student.Presentation;

public class StudentContextFactory : IDesignTimeDbContextFactory<StudentContext>
{
    public StudentContext CreateDbContext(string[] args)
    {
        // Genbrug den samme centrale metode til værktøjer (migrations)
        return new StudentContext(Program.ConfigureOptions());
    }
}