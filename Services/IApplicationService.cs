using HanoiStudentGigs.Models;

public interface IApplicationService
{
    void Apply(Application application);
    IEnumerable<Application> GetApplicationsByStudentId(int studentId);
    IEnumerable<Application> GetApplicationsByJobId(int jobId);
}