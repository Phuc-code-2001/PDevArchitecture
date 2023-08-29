using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.Core.Repositories.Interfaces;

namespace PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces
{
    public interface IQueryRepository<TEntity, TPrimary> :
        IHasGetListRepository<TEntity>,
        IHasRetrieveRepository<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {

    }
}
