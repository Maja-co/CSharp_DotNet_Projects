using Microsoft.EntityFrameworkCore;
using Student.Data.Data;
using Student.Data.Models;

namespace Student.Data.Repository;

public class StudentRepository : IStudentRepository {
    private readonly StudentContext _dbContext;

    public StudentRepository(StudentContext dbContext) {
        _dbContext = dbContext;
    }

    // Hent alle studerende
    public async Task<List<StudentEntity>> GetAllStudentsAsync() {
        return await _dbContext.Students.ToListAsync();
    }

    // Hent en studerende ud fra id
    public async Task<StudentEntity?> GetStudentAsync(int id) {
        return await _dbContext.Students.FindAsync(id);
    }

    // Opret en studerende
    public async Task AddStudentAsync(StudentEntity student) {
        try {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
        } catch (DbUpdateException ex) {
            throw new Exception("Kunne ikke tilføje studerende til databasen", ex);
        }
    }
    
    // Slet en studerende
    public async Task DeleteStudentAsync(int id) {
        try {
            var studentToDelete = await _dbContext.Students.FindAsync(id);
            if (studentToDelete != null) {
                _dbContext.Students.Remove(studentToDelete);
                await _dbContext.SaveChangesAsync();
            }
        } catch (DbUpdateException ex) {
            throw new Exception("Kunne ikke slette studerende fra databasen", ex);
        }
    }
    
    // Opdatere studerende
    public async Task UpdateStudentAsync(StudentEntity updatedStudent) {
        var existingStudent = await _dbContext.Students.FindAsync(updatedStudent.StudentId);
        if (existingStudent != null) {
            // Opdater Studerende
            existingStudent.Name = updatedStudent.Name;
            existingStudent.Studiestart = updatedStudent.Studiestart;
            existingStudent.Age = updatedStudent.Age;
            existingStudent.StudentType = updatedStudent.StudentType;

            await _dbContext.SaveChangesAsync();
        } else {
            throw new Exception("Studenten findes ikke");
        }
    }
}