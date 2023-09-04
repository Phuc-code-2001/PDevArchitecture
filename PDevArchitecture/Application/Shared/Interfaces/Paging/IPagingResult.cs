namespace PDevArchitecture.Application.Shared.Interfaces.Paging
{
    public interface IPagingResult
    {
        object Items { get; set; }
        long TotalCount { get; set; }
    }
}
