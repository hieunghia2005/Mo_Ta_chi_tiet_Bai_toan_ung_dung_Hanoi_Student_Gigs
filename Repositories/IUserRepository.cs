using HanoiStudentGigs.Models;

public interface IUserRepository
{
    User? GetByEmail(string email);
    User? GetById(int id);
    void Add(User user);
    IEnumerable<User> GetAll();
}