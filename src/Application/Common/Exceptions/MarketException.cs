namespace POS.Application.Common.Exceptions;
public class MarketException : Exception
{
    public readonly string ErrorMessage;

    public MarketException(string message)
    {
        ErrorMessage = message;
    }
}