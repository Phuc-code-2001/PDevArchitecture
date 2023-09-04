using PDevArchitecture.Application.Shared.Interfaces.Filters;
using PDevArchitecture.Application.Shared.Interfaces.Paging;

namespace PDevArchitecture.Application.Shared.Interfaces.Mixins
{
    public interface IPagingFilterBackend<TEntity> : IFilterBackend<TEntity>, 
        IPagingHandler<IPagingRequest, IPagingResult>
    {

    }
}
