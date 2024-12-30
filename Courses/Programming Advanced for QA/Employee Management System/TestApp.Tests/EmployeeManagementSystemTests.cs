using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class EmployeeManagementSystemTests
{
    [Test]
    public void Test_Constructor_CheckInitialEmptyEmployeeCollectionAndCount()
    {
        // Arrange
        EmployeeManagementSystem ems = new EmployeeManagementSystem();

        // Act
        List<string> employees = ems.GetAllEmployees();
        int count = ems.EmployeeCount;

        // Assert
        Assert.IsNotNull(employees);
        Assert.IsEmpty(employees);
        Assert.AreEqual(0, count);

    }

    [Test]
    public void Test_AddEmployee_ValidEmployeeName_AddNewEmployee()
    {
        // Arrange
        EmployeeManagementSystem ems = new EmployeeManagementSystem();

        // Act
        ems.AddEmployee("Alekszandar");
        List<string> result = ems.GetAllEmployees();

        List<string> expected = new List<string>() { "Alekszandar" };

        // Assert
        Assert.That(result, Is.EqualTo(expected));   
        
    }

    [Test]
    public void Test_AddEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException()
    {
        // Arrange
        EmployeeManagementSystem ems = new EmployeeManagementSystem();

        // Act & Assert        
        Assert.Throws<ArgumentException>(() => ems.AddEmployee(null), "Employee name cannot be empty or whitespace.");

    }

    [Test]
    public void Test_RemoveEmployee_ValidEmployeeName_RemoveFirstEmployeeName()
    {
        // Arrange
        EmployeeManagementSystem ems = new EmployeeManagementSystem();

        // Act
        ems.AddEmployee("Alekszandar Tsvetkov");
        ems.AddEmployee("Ivan Ivanov");
        ems.AddEmployee("Petur Petrov");
        ems.RemoveEmployee("Alekszandar Tsvetkov");

        List<string> employees = new List<string>() { "Ivan Ivanov", "Petur Petrov" };

        List<string> result = ems.GetAllEmployees();

        // Assert
        Assert.That(result, Is.EqualTo(employees));
        
    }

    [Test]
    public void Test_RemoveEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException()
    {
        // Arrange
        EmployeeManagementSystem ems = new EmployeeManagementSystem();

        // Act & Assert        
        Assert.Throws<ArgumentException>(() => ems.RemoveEmployee(null), "Employee not found in the system.");
    }

    [Test]
    public void Test_GetAllEmployees_AddedAndRemovedEmployees_ReturnsExpectedEmployeeCollection()
    {
        // Arrange
        EmployeeManagementSystem ems = new EmployeeManagementSystem();

        // Act
        ems.AddEmployee("Alekszandar Tsvetkov");
        ems.AddEmployee("Ivan Ivanov");
        ems.AddEmployee("Petur Petrov");
        ems.AddEmployee("Georgi Georgiev");

        ems.RemoveEmployee("Ivan Ivanov");
        ems.RemoveEmployee("Petur Petrov");

        List<string> employees = new List<string>() { "Alekszandar Tsvetkov", "Georgi Georgiev" };

        List<string> result = ems.GetAllEmployees();

        // Assert
        Assert.That(result, Is.EqualTo(employees));
    }   
}

