namespace PDevArchitecture.Application.Shared.Interfaces.Paging
{
    public interface IPagingResult<T>
    {
        List<T> Items { get; set; }
        long TotalCount { get; set; }

    }
}
