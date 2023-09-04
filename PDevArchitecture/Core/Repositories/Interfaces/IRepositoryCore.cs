using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PDevArchitecture.Core.Entities.Abstracts;

namespace PDevArchitecture.Core.Repositories.Interfaces
{
    public interface IRepositoryCore<TEntity, TPrimary> : IRepository
        where TEntity : BaseEntity<TPrimary>
    {
        DbContext DbContext {  get; }
        DbSet<TEntity> EntitySet { get; }

    }
}
