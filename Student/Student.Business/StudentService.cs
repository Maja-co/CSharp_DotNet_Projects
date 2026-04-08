using Student.Data.Models;
using Student.Data.Repository;

namespace Student.Business {
    public class StudentService {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository) {
            _repository = repository;
        }

        public async Task<List<StudentEntity>> GetAllStudentsAsync() {
            return await _repository.GetAllStudentsAsync();
        }

        public async Task<StudentEntity?> GetStudentAsync(int id) {
            return await _repository.GetStudentAsync(id);
        }

        public async Task AddStudentAsync(StudentEntity student) {
            await _repository.AddStudentAsync(student);
        }

        public async Task DeleteStudentAsync(int id) {
            await _repository.DeleteStudentAsync(id);
        }

        public async Task UpdateStudentAsync(StudentEntity student) {
            await _repository.UpdateStudentAsync(student);
        }
    }
}