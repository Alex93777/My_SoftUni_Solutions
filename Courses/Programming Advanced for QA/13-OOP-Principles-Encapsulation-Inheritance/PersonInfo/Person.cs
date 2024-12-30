using System;

namespace PersonInfo;

public class Person
{
    private string firstName;                       //създаваме fields
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName                                //Alt + Enter (Encapsulate Properties)
    {
        get => firstName;
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            firstName = value;
        }
    }
    public string LastName
    {
        get => lastName;
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            lastName = value;
        }
    }
    public int Age
    {
        get => age;
        private set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }
    public override string ToString()                               // Пишем public override -> Alt + Enter -> ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";          // Добавяме текста който искаме да бъде отпечатан
    }
}
