using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> nullList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> oneElementList = new() { 42 };

        // Act
        int result = MaxNumber.FindMax(oneElementList);

        //  Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> positiveList = new() { 1, 2, 3, 4, 5, 42 };

        // Act
        int result = MaxNumber.FindMax(positiveList);

        //  Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeList = new() { -1, -2, -3, -4, -5, -42 };

        // Act
        int result = MaxNumber.FindMax(negativeList);

        //  Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> mixedList = new() { 20, 15, -10, -40, -45, -50 };

        // Act
        int result = MaxNumber.FindMax(mixedList);

        //  Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> duplicateList = new() { 10, 15, 15, 9, 8, 7, 15 };

        // Act
        int result = MaxNumber.FindMax(duplicateList);

        //  Assert
        Assert.That(result, Is.EqualTo(15));
    }
}
