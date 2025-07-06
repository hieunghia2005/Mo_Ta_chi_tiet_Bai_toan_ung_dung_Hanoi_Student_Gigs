using HanoiStudentGigs.Models;

public interface IJobRepository
{
    IEnumerable<Job> GetAll();
    Job? GetById(int id);
    void Add(Job job);
    void Update(Job job);
    void Delete(int id);
    IEnumerable<Job> Search(string keyword);
}