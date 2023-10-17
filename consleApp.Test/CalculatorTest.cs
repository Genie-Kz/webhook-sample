namespace consleApp.Test;

public class CalculatorTest
{
    [Fact]
    public void AddTest()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(1, 2);

        // Assert
        Assert.Equal(3, result);
    }
}