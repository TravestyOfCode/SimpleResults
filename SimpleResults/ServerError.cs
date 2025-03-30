namespace SimpleResults;

public class ServerError : Error
{
    public ServerError() : this("Server Error") { }
    public ServerError(string message)
    {
        ErrorCode = 500;
        ErrorMessage = message;
    }
}
