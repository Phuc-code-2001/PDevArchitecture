using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.Core.Repositories.Abstracts;
using PDevArchitecture.Core.Repositories.Interfaces;
using System.Linq.Expressions;

namespace PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces
{
    public interface IEfCoreRepository<TEntity, TPrimary> 
        : IRepositoryCore<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {
        IQueryable<TEntity> GetAsQueryable(bool tracked = true);
    }
}
