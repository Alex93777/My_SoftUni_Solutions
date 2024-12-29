using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition_WhenParametarsArePositive()
    {
        // Arrange
        Calculate calculator = new();


        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    public void Test_AdditionWhenParametersAreNegative()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(-5, -2);

        //Assert
        Assert.Less(actual, 0);
        Assert.AreEqual(actual, - 7);

    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
        Calculate calculator = new();

        //Act
        int actual = calculator.Subtraction (5, 2);

        //Assert
        Assert.Less(actual, 0);
        Assert.AreEqual(-7, actual);


    }
}
