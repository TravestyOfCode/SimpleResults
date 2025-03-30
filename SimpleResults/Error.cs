using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SimpleResults;

public class Error
{
    public int ErrorCode { get; set; }
    public required string ErrorMessage { get; set; }
    public Dictionary<string, List<string>> ModelState { get; } = [];

    [SetsRequiredMembers]
    public Error(int errorCode, string errorMessage)
    {
        ArgumentNullException.ThrowIfNull(errorMessage);

        ErrorCode = errorCode;

        ErrorMessage = errorMessage;
    }
}
