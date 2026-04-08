using Student.Data.Models;

namespace Student.Data.Repository;

public interface IStudentRepository {
    Task<List<StudentEntity>> GetAllStudentsAsync();
    Task<StudentEntity?> GetStudentAsync(int id);
    Task AddStudentAsync(StudentEntity student);
    Task DeleteStudentAsync(int id);
    Task UpdateStudentAsync(StudentEntity student);
}