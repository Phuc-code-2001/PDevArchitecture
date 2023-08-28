namespace PDevArchitecture.Application.Shared.Interfaces.Paging
{
    public interface IPagingRequest
    {
        long SkipCount { get; set; }
        long TakeCount { get; set; }
    }
}
