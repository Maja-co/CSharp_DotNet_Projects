using System.ComponentModel.DataAnnotations;


namespace Student.Data.Models;

public class StudentEntity {
    [Key] public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime Studiestart { get; set; } = DateTime.Today;
    public int Age { get; set; }
    public StudentType StudentType { get; set; }
}