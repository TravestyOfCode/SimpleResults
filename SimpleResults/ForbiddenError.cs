using System.Diagnostics.CodeAnalysis;

namespace SimpleResults;

public class ForbiddenError : Error
{
    [SetsRequiredMembers]
    public ForbiddenError() : this("Forbidden") { }

    [SetsRequiredMembers]
    public ForbiddenError(string message) : base(403, message) { }
}
