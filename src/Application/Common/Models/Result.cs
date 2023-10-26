namespace POS.Application.Common.Models;

public class Result
{
    public bool IsSuccess { get; set; } = true;
    public string ErrorMessage { get; set; } = string.Empty;

    public Result() { }

    public Result(bool success, string message)
    {
        IsSuccess = success;
        ErrorMessage = message;
    }
}