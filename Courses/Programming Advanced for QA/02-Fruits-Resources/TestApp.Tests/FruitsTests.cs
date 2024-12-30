using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new Dictionary<string, int>
        {
            { "apple", 10},
            { "banana", 15},
            { "orange", 25}
        };

        string askedFruids = "banana";
        int quantity = 15;

        // Act
        int result = Fruits.GetFruitQuantity(fruitsDictionary, askedFruids);

        // Assert
        Assert.That(result, Is.EqualTo(quantity));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new Dictionary<string, int>
        {
            { "apple", 10},
            { "banana", 15},
            { "orange", 25}
        };

        string askedFruids = "kiwi";
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitsDictionary, askedFruids);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new();
        string askedFruid = "apple";

        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitsDictionary, askedFruid);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = null;
        string fruitName = "apple";

        int expected = 0;


        // Act
        int result = Fruits.GetFruitQuantity(input, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new Dictionary<string, int>
        {
            { "apple", 10},
            { "banana", 15},
            { "orange", 25}
        };

        string askedFruids = null;
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitsDictionary, askedFruids);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
