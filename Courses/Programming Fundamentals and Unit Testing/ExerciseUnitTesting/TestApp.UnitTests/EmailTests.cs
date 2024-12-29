using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string email = "test@example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(email);

        // Assert
        Assert.That(isValidEmail, Is.EqualTo(true));

    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string email = "test.example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(email);

        // Assert
        Assert.That(isValidEmail, Is.EqualTo(false));
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string email = null;

        // Act
        bool isValidEmail = Email.IsValidEmail(email);

        // Assert
        Assert.That(isValidEmail, Is.EqualTo(false));
    }
    [Test]
    public void Test_IsValidEmail_WideSpaceEmail()
    {
        // Arrange
        string email = "    ";

        // Act
        bool isValidEmail = Email.IsValidEmail(email);

        // Assert
        Assert.That(isValidEmail, Is.EqualTo(false));
    }
}
