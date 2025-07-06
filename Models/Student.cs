namespace HanoiStudentGigs.Models;

public class Student
{
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string? University { get; set; }
        public string? Major { get; set; }
        public string? StudyYear { get; set; }
        public string? ResumeFilePath { get; set; }
        public string? About { get; set; }
        public User? User { get; set; }
        public List<Skill> Skills { get; set; } = new();
        public List<Application> Applications { get; set; } = new();

}