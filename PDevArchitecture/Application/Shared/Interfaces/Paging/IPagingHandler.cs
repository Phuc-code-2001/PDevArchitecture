namespace PDevArchitecture.Application.Shared.Interfaces.Paging
{
    public interface IPagingHandler<TRequest, TResult>
        where TRequest : IPagingRequest
        where TResult : IPagingResult
    {
        TResult GetPagingResult(TRequest request);
    }
}
