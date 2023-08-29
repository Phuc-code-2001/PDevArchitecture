using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;

namespace PDevArchitecture.EntityFrameworkCore.Repositories
{
    public class EfCoreRepository<TEntity, TPrimary> : CRUDRepository<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {
        public EfCoreRepository(ICommandRepository<TEntity, TPrimary> command, IQueryRepository<TEntity, TPrimary> query) : base(command, query)
        {

        }
    }

    public class EfCoreRepository<TEntity> : EfCoreRepository<TEntity, Guid>
        where TEntity : BaseEntity<Guid>
    {
        public EfCoreRepository(ICommandRepository<TEntity, Guid> command, IQueryRepository<TEntity, Guid> query) : base(command, query)
        {

        }
    }
}
