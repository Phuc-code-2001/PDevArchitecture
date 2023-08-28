namespace PDevArchitecture.Application.Shared.Interfaces.Paging
{
    public interface IPagingHandler<TRequest, TResult>
    {
        TResult GetPagingResult(TRequest request);
    }
}
