using HanoiStudentGigs.Models;

public interface IJobService
{
    IEnumerable<Job> GetAllJobs();
    Job? GetJob(int id);
    void PostJob(Job job);
    void EditJob(Job job);
    void RemoveJob(int id);
    IEnumerable<Job> SearchJobs(string keyword);
}