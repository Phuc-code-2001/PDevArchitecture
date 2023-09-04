using Microsoft.EntityFrameworkCore;
using PDevArchitecture.Application.Shared.Consts;
using PDevArchitecture.Application.Shared.Exceptions;
using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.Core.Repositories.Abstracts;
using PDevArchitecture.Core.Repositories.Interfaces;
using PDevArchitecture.EntityFrameworkCore.DataAccess;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;

namespace PDevArchitecture.EntityFrameworkCore.Repositories
{
    public class EfCoreRepository<TEntity, TPrimary> : RepositoryCore<TEntity, TPrimary>,
        IEfCoreRepository<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {

        public EfCoreRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<TEntity> GetAsQueryable(bool tracked = true)
        {
            return tracked ? EntitySet : EntitySet.AsNoTracking();
        }
    }
}
