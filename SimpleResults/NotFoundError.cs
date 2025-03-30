namespace SimpleResults;

public class NotFoundError : Error
{
    public NotFoundError() : this("Not Found") { }
    public NotFoundError(string message)
    {
        ErrorCode = 404;
        ErrorMessage = message;
    }
    public NotFoundError(string property, string message) : this("Not Found")
    {
        if (ModelState.TryGetValue(property, out var list))
        {
            list.Add(message);
        }
        else
        {
            ModelState[property] = [message];
        }
    }
}
