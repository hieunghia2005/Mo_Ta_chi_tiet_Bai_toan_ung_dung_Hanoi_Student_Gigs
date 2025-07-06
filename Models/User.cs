namespace HanoiStudentGigs.Models;

public class User
{
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Role { get; set; } = null!; // "Student", "Employer", "Admin"
        public Student? Student { get; set; }
        public Employer? Employer { get; set; }
}