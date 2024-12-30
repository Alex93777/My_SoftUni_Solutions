using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> students = new Dictionary<string, int>()
        {
            { "Ivan", 5 },
            { "Petur", 4 },
            { "Ivo", 3 },
            { "Dido", 5},
            { "Alex", 6}
        };

        string expected = $"Alex with average grade 6.00{Environment.NewLine}" +
            $"Dido with average grade 5.00{Environment.NewLine}" +
            $"Ivan with average grade 5.00";

        // Act
        string result = Grades.GetBestStudents(students);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> students = new Dictionary<string, int>()
        {            
        };

        string expected = string.Empty;

        // Act
        string result = Grades.GetBestStudents(students);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> students = new Dictionary<string, int>()
        {
            { "Alex", 6 },
            { "Ivan", 5 },
        };

        string expected = $"Alex with average grade 6.00{Environment.NewLine}" +
                          $"Ivan with average grade 5.00";

        // Act
        string result = Grades.GetBestStudents(students);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> students = new Dictionary<string, int>()
        {
            { "Alex", 6 },
            { "Bobi", 6 },
            { "Dido", 6 },
            { "Ivo", 6 },
            { "Pesho", 6 }
        };

        string expected = $"Alex with average grade 6.00{Environment.NewLine}" +
                          $"Bobi with average grade 6.00{Environment.NewLine}" +
                          $"Dido with average grade 6.00";
                          

        // Act
        string result = Grades.GetBestStudents(students);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
