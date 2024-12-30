using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int rotations = 5;

        string expected = string.Empty;

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "abcde";
        int rotations = 0;

        string expected = "abcde";

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "alex";
        int rotations = 1;

        string expected = "xale";

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "alex";
        int rotations = -1;

        string expected = "xale";

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "alex";
        int rotations = 5;

        string expected = "xale";

        // Act
        string result = StringRotator.RotateRight(input, rotations);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
