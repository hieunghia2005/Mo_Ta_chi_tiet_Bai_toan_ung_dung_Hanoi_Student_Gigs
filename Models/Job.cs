namespace HanoiStudentGigs.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public string Location { get; set; }
        public string WorkTime { get; set; }
        public string Salary { get; set; }
        public object Deadline { get; set; }
        public bool IsApproved { get; set; }
        public int EmployerId { get; set; }
        
    }
}