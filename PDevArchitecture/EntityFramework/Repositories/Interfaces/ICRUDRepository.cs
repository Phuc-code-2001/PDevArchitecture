using PDevArchitecture.Core.Entities.Abstracts;

namespace PDevArchitecture.EntityFramework.Repositories.Interfaces
{
    public interface ICRUDRepository<TEntity, TPrimary> :
        IQueryRepository<TEntity, TPrimary>,
        ICommandRepository<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {

    }
}
