namespace HanoiStudentGigs.Models;

public class Skill
{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Student> Students { get; set; } = new();
        public List<Job> Jobs { get; set; } = new();
}