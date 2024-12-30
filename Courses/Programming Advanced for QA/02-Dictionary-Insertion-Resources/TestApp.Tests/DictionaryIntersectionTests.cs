using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        var expected  = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {

        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            { "apple",  1 },
            { "banana", 3},
            { "avocado", 2}
        };

        var expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            { "mango", 1},
            { "cherry", 3},
            { "strawberry", 2}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            { "apple",  1 },
            { "banana", 3},
            { "avocado", 2}
        };

        var expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            { "apple", 2 },
            { "avocado", 2 },
            { "banana", 2 }
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            { "banana", 2 },
            { "apple",  2 },
            { "avocado", 2 }
        };

        var expected = new Dictionary<string, int>()
        {
            { "apple", 2 },
            { "banana", 2 },
            { "avocado", 2 },
        };

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            { "apple", 3},
            { "avocado", 4},
            { "strawberry", 5}
        };
        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            { "strawberry", 2},
            { "apple",  2 },
            { "avocado", 2}
        };

        var expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
