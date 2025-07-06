namespace HanoiStudentGigs.Models;

public class Application
{
        public int Id { get; set; }
        public int JobId { get; set; }
        public int StudentId { get; set; }
        public DateTime AppliedAt { get; set; } = DateTime.UtcNow;
        public string? Message { get; set; }
        public string? ResumeFilePath { get; set; }
        public Job? Job { get; set; }
        public Student? Student { get; set; }

}