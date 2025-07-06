namespace HanoiStudentGigs.Models;

public class Location
{
        public int Id { get; set; }
        public string DistrictName { get; set; } = null!;
        public List<Job> Jobs { get; set; } = new();
}