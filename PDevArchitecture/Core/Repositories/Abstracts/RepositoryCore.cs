using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
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
        
        public DbContext DbContext => _dbContext;
        public DbSet<TEntity> EntitySet => _dbContext.Set<TEntity>();

  
    }
}
