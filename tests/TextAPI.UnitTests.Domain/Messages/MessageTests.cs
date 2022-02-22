using System;
using FluentAssertions;
using TextAPI.Domain.Messages;
using TextAPI.Domain.Messages.Exceptions;
using Xunit;

namespace TextAPI.UnitTests.Domain.Messages;

public class MessageTests
{
    [Fact]
    public void CanCreateValidMessage()
    {
        const string recipient = "0048123456789";
        const string content = "Hello World";

        var message = new Message(recipient, content);

        message.Recipient.Should().Be(recipient);
        message.Content.Should().Be(content);
    }

    [Fact]
    public void CannotCreateMessageWithInvalidRecipient()
    {
        const string recipient = "+48 123 456 789";
        const string content = "Hello World";

        var act = () => new Message(recipient, content);

        act.Should()
            .Throw<InvalidRecipientException>();
    }

    [Fact]
    public void CannotCreateTooLongMessage()
    {
        const string recipient = "0048123456789";
        var content = new string('x', 71);

        var act = () => new Message(recipient, content);

        act.Should()
            .Throw<MessageTooLongException>();
    }
}