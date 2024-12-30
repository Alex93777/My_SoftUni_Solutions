using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        
        string sender = "Alex";
        string message = "Hello";


        // Act
        _chatRoom.SendMessage(sender, message);
        string result = _chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("Alex: Hello - Sent at"));


    }
    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange
        
        // Act
        string actualResult = _chatRoom.DisplayChat();

        // Assert
        Assert.That(actualResult, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        string sender = "Alex";
        string message = "Hello";

        string sender2 = "Ina";
        string message2 = "Hi, Alex";

        // Act
        _chatRoom.SendMessage(sender, message);
        _chatRoom.SendMessage(sender2, message2);
        string result = _chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("Alex: Hello - Sent at"));
        Assert.That(result, Does.Contain("Ina: Hi, Alex - Sent at"));
    }
}
