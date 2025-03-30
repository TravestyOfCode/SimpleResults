using System.Collections.Generic;

namespace SimpleResults;

public class Error
{
    public int ErrorCode { get; set; }
    public required string ErrorMessage { get; set; }
    public Dictionary<string, List<string>> ModelState { get; } = [];
}
