namespace UnitTestApplication.Users;

public class UserService(IUserRepository userRepository)
{
    private readonly IUserRepository _userRepository = userRepository;

    public void AddUser(User user)
    {
        _userRepository.AddUser(user);
    }

    public void UpdateUser(User user)
    {
        _userRepository.UpdateUser(user);
    }

    public void DeleteUser(int id)
    {
        _userRepository.DeleteUser(id);
    }

    public string GetUserName(int id)
    {
        var user = _userRepository.GetUserById(id);
        return user?.Name;
    }
}
