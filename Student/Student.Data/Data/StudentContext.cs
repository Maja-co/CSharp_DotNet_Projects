using Microsoft.EntityFrameworkCore;

namespace Student.Data.Data;

public class StudentContext : DbContext {
    public DbSet<Models.StudentEntity> Students { get; set; }

    public StudentContext(DbContextOptions<StudentContext> options) : base(options) {
        
    }

    protected StudentContext() {
    }
}