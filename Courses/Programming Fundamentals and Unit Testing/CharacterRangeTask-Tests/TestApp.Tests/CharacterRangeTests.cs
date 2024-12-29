using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        string result = CharacterRange.GetRange('A', 'B');

        // Act & Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        string result = CharacterRange.GetRange('B', 'A');

        // Act & Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        string result = CharacterRange.GetRange('A', 'C');

        // Act & Assert
        Assert.AreEqual("B", result);
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        string result = CharacterRange.GetRange('D', 'G');

        // Act & Assert
        Assert.AreEqual("E F", result);
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        string result = CharacterRange.GetRange('X', 'Z');

        // Act & Assert
        Assert.AreEqual("Y", result);
    }
}
