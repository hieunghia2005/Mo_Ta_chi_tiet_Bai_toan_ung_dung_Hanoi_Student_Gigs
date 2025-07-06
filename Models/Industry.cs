namespace HanoiStudentGigs.Models;

public class Industry
{
    
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Job> Jobs { get; set; } = new();

}