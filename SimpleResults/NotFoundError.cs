using System.Diagnostics.CodeAnalysis;

namespace SimpleResults;

public class NotFoundError : Error
{
    [SetsRequiredMembers]
    public NotFoundError() : this("Not Found") { }

    [SetsRequiredMembers]
    public NotFoundError(string message) : base(404, message) { }

    [SetsRequiredMembers]
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
