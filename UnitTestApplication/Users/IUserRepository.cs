namespace UnitTestApplication.Users;

public interface IUserRepository
{
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(int id);
    User GetUserById(int id);
}
