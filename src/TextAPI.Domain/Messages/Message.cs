using TextAPI.Domain.Messages.Exceptions;

namespace TextAPI.Domain.Messages;

public class Message
{
    public Message(string recipient, string content)
    {
        SetRecipient(recipient);
        SetContent(content);
    }

    public Guid Id { get; } = new Guid();
    
    public string Recipient { get; private set; }
    public string Content { get; private set; }

    private void SetRecipient(string recipient)
    {
        if (!recipient.All(char.IsDigit)) throw new InvalidRecipientException();
        Recipient = recipient;
    }

    private void SetContent(string content)
    {
        if (content.Length > 70) throw new MessageTooLongException();
        Content = content;
    }
}