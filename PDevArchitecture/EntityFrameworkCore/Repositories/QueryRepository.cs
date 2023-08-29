using Microsoft.EntityFrameworkCore;
using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.Core.Repositories.Abstracts;
using PDevArchitecture.EntityFrameworkCore.DataAccess;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;

namespace PDevArchitecture.EntityFrameworkCore.Repositories
{
    public class QueryRepository<TEntity, TPrimary> : RepositoryCore<TEntity, TPrimary>,
        IQueryRepository<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {
        public QueryRepository(AppDbContext dbContext, IConfiguration configuration)
            : base(dbContext, configuration)
        {
        }

        public virtual IQueryable<TEntity> GetList(bool tracked = false)
        {
            if (tracked)
            {
                return _dbContext.Set<TEntity>();
            }
            return _dbContext.Set<TEntity>().AsNoTracking();
        }
        public virtual TEntity? Get(TPrimary? Id, bool tracked)
        {

            if (tracked)
            {
                return _dbContext.Set<TEntity>()
                    .FirstOrDefault(x => x.Id!.Equals(Id));
            }
            else
            {
                return _dbContext.Set<TEntity>().AsNoTracking()
                    .FirstOrDefault(x => x.Id!.Equals(Id));
            }
        }
    }
}
