﻿using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;
        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = "";
        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange 
        string path = "D:\\QA\\demo.txt"; 
        // Act
        string expected = ExtractFile.GetFile(path);
        // Assert
        Assert.That(expected, Is.EqualTo("File name: demo\nFile extension: txt"));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange 
        string path = "D:\\QA\\demo";
        // Act
        string expected = ExtractFile.GetFile(path);
        // Assert
        Assert.That(expected, Is.EqualTo("File name: demo"));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange 
        string path = "D:\\QA\\demo$%.txt$";
        // Act
        string expected = ExtractFile.GetFile(path);
        // Assert
        Assert.That(expected, Is.EqualTo("File name: demo$%\nFile extension: txt$"));
    }
}
