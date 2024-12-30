using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringModifierTests
{
    [Test]
    public void Test_Modify_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act

        string result = StringModifier.Modify(input);

        string expected = string.Empty;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_SingleWordWithEvenLength_ReturnsUppperCaseWord()
    {
        // Arrange
        string input = "alex";

        // Act

        string result = StringModifier.Modify(input);

        string expected = "ALEX";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_SingleWordWithOddLength_ReturnsToLowerCaseWord()
    {
        // Arrange
        string input = "Alekszandar";

        // Act

        string result = StringModifier.Modify(input);

        string expected = "alekszandar";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_MultipleWords_ReturnsModifiedString()
    {
        // Arrange
        string input = "Alekszandar alex The King";

        // Act

        string result = StringModifier.Modify(input);

        string expected = "alekszandar ALEX the KING";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

