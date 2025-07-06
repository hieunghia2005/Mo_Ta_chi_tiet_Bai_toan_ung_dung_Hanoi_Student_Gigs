using HanoiStudentGigs.Models;

public class StudentProfile
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string University { get; set; }
    public string Major { get; set; }
    public string Experience { get; set; }
    public string Skills { get; set; }
    public string Projects { get; set; }
    public string CvFilePath { get; set; }

    public string UserId { get; set; }
    
    public ApplicationUser User { get; set; }
}