namespace TextAPI.Domain.Messages.Exceptions;

public class MessageTooLongException : Exception
{
    public MessageTooLongException() : base("Message is too long according to 16-bit SMS standard.")
    {
        
    }
}