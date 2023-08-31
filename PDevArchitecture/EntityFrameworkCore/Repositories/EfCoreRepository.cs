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

        private readonly ILogger _logger;

        public EfCoreRepository(AppDbContext dbContext, ILogger logger) : base(dbContext)
        {
            _logger = logger;
        }

        public async Task<TResult> HandleTransaction<TResult>(Func<IQueryable<TEntity>, TResult> handler)
        {
            using(var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var queyable = await GetAsQueryable();
                    return handler(queyable);
                }
                catch(Exception ex)
                {
                    _logger.LogError(ex.Message, ex);
                    transaction.Rollback();
                    throw new HttpException()
                        .WithStatusCode(500)
                        .WithUserFriendlyMessage(HttpMessageConsts.ServerInternalError);
                }
            }

        }
    }
}
