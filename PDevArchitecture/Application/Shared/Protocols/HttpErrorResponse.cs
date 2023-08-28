namespace PDevArchitecture.Application.Shared.Protocols
{
    public class HttpErrorResponse
    {
        public string? Message { get; set; }
        public List<KeyValuePair<string, string?>> Details { get; set; } = new() { };
    }
}
