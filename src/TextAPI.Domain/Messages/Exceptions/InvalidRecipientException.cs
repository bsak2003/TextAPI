namespace TextAPI.Domain.Messages.Exceptions;

public class InvalidRecipientException : Exception
{
    public InvalidRecipientException(): base("Recipient contains other characters than digits.")
    {
        
    }
}