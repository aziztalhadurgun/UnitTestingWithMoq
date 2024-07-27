using Moq;
using UnitTestApplication.Users;

namespace UnitTestApplication.Tests;

public class UserServiceTest
{
    [Fact]
    public void GetUserName_ReturnsCorrectName()
    {
        // Arrange: Mock nesnesi oluşturma ve bağımlılıkları ayarlama
        var userRepositoryMock = new Mock<IUserRepository>();
        userRepositoryMock.Setup(repo => repo.GetUserById(1)).Returns(new User { Id = 1, Name = "Aziz Talha" });

        var userService = new UserService(userRepositoryMock.Object);

        // Act: Test edilen metodu çağırma
        var result = userService.GetUserName(1);
        
        // Assert: Beklenen sonucu doğrulama
        Assert.Equal("Aziz Talha", result);

        // Doğrulama: GetUserById metodunun belirli parametrelerle çağrıldığını doğrulama
        userRepositoryMock.Verify(repo => repo.GetUserById(1), Times.Once);
    }

    [Fact]
    public void AddUser_CallsAddUserOnRepository()
    {
        // Arrange
        var userRepositoryMock = new Mock<IUserRepository>();
        var userService = new UserService(userRepositoryMock.Object);
        var user = new User { Id = 1, Name = "Aziz Talha" };
        
        // Act
        userService.AddUser(user);
        
        // Assert
        userRepositoryMock.Verify(repo => repo.AddUser(user), Times.Once);
    }

    [Fact]
    public void UpdateUser_CallsUpdateUserOnRepository()
    {
        // Arrange
        var userRepositoryMock = new Mock<IUserRepository>();
        var userService = new UserService(userRepositoryMock.Object);
        var user = new User { Id = 1, Name = "Aziz Talha" };
        
        // Act
        userService.UpdateUser(user);
        
        // Assert
        userRepositoryMock.Verify(repo => repo.UpdateUser(user), Times.Once);
    }

    [Fact]
    public void DeleteUser_CallsDeleteUserOnRepository()
    {
        // Arrange
        var userRepositoryMock = new Mock<IUserRepository>();
        var userService = new UserService(userRepositoryMock.Object);
        
        // Act
        userService.DeleteUser(1);
        
        // Assert
        userRepositoryMock.Verify(repo => repo.DeleteUser(1), Times.Once);
    }
}
