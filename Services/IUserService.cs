using HanoiStudentGigs.Models;

public interface IUserService
{
    User? GetUserByEmail(string email);
    User? GetUserById(int id);
    void RegisterUser(User user);
    IEnumerable<User> GetAllUsers();

    Student? GetStudentById(int id);
    void UpdateStudent(Student student);
}