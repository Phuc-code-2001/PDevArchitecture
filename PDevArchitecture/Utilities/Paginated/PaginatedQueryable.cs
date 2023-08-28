using PDevArchitecture.Application.Shared.Interfaces.Paging;

namespace PDevArchitecture.Utilities.Paginated
{
    public class PaginatedQueryable<T> : IPagingHandler<IPagingRequest, IPagingResult<T>>
    {

        IPagingRequest _pagingRequest;

        public PaginatedQueryable(IQueryable<T> source, IPagingRequest paging)
        {
            _pagingRequest = paging;
        }

        public IPagingResult<T> GetPagingResult(IPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
