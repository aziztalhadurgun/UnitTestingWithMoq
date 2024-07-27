namespace UnitTestApplication.Tests;

public class UnitTest1
{
     [Fact]
    public void Add_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(5, 3);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(5, 3);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectMultiplication()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Multiply(5, 3);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Divide_ReturnsCorrectQuotient()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Divide(10, 2);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZeroThrowsException()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}