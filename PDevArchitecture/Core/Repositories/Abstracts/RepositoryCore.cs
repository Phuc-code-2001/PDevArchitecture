using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.Core.Repositories.Interfaces;
using PDevArchitecture.EntityFrameworkCore.DataAccess;

namespace PDevArchitecture.Core.Repositories.Abstracts
{
    public abstract class RepositoryCore<TEntity, TPrimary> : IRepositoryCore<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {
        protected readonly AppDbContext _dbContext;

        public RepositoryCore(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<TEntity>> GetAsQueryable()
        {
            return await Task.FromResult(_dbContext.Set<TEntity>());
        }
    }
}
