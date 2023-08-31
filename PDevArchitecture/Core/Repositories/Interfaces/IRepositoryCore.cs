using PDevArchitecture.Core.Entities.Abstracts;

namespace PDevArchitecture.Core.Repositories.Interfaces
{
    public interface IRepositoryCore<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {
        Task<IQueryable<TEntity>> GetAsQueryable();
    }
}
