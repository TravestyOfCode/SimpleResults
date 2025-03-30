namespace SimpleResults;

public class BadRequestError : Error
{
    public BadRequestError() : this("Bad Request") { }
    public BadRequestError(string message)
    {
        ErrorCode = 400;
        ErrorMessage = message;
    }
    public BadRequestError(string property, string message) : this("Bad Request")
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
