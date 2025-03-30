namespace SimpleResults;

public class ForbiddenError : Error
{
    public ForbiddenError() : this("Forbidden") { }
    public ForbiddenError(string message)
    {
        ErrorCode = 403;
        ErrorMessage = message;
    }
}
