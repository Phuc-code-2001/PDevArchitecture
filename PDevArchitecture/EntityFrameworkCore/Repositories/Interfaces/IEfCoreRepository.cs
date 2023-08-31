using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.Core.Repositories.Interfaces;

namespace PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces
{
    public interface IEfCoreRepository<TEntity, TPrimary> : IRepositoryCore<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {
        Task<TResult> HandleTransaction<TResult>(Func<IQueryable<TEntity>, TResult> handler);
    }
}
