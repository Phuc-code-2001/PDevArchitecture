using Microsoft.EntityFrameworkCore;
using PDevArchitecture.Application.Shared.Consts;
using PDevArchitecture.Application.Shared.Exceptions;
using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.Core.Repositories.Abstracts;
using PDevArchitecture.EntityFrameworkCore.DataAccess;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;

namespace PDevArchitecture.EntityFrameworkCore.Repositories
{
    public class CommandRepository<TEntity, TPrimary> : RepositoryCore<TEntity, TPrimary>,
        ICommandRepository<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>

    {
        public CommandRepository(AppDbContext dbContext, IConfiguration configuration)
            : base(dbContext, configuration)
        {

        }

        public TEntity Create(TEntity entity)
        {
            try
            {
                var entry = _dbContext.Entry(entity);
                if (entry.State == EntityState.Detached)
                {
                    _dbContext.Set<TEntity>().Add(entity);
                    _dbContext.SaveChanges();
                }

                return entity;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException()
                    .FromBase(ex)
                    .WithStatusCode(StatusCodes.Status500InternalServerError)
                    .WithUserFriendlyMessage(HttpMessageConsts.ServerInternalError);
            }
        }

        public TEntity Update(TEntity entity)
        {
            try
            {
                var entry = _dbContext.Entry(entity);
                if (entry.State == EntityState.Unchanged)
                {
                    _dbContext.Set<TEntity>().Update(entity);
                    _dbContext.SaveChanges();
                }

                return entity;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException()
                    .FromBase(ex)
                    .WithStatusCode(StatusCodes.Status500InternalServerError)
                    .WithUserFriendlyMessage(HttpMessageConsts.ServerInternalError);
            }
        }

        public bool Delete(TEntity entity, bool permanent = false)
        {
            try
            {
                var entry = _dbContext.Entry(entity);
                if (entry.State == EntityState.Unchanged)
                {
                    if (permanent)
                    {
                        _dbContext.Set<TEntity>().Remove(entity);
                        _dbContext.SaveChanges();
                    }
                    else
                    {
                        entity.RemovedAt = DateTime.Now;
                        _dbContext.Set<TEntity>().Update(entity);
                        _dbContext.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new HttpResponseException()
                    .FromBase(ex)
                    .WithStatusCode(StatusCodes.Status500InternalServerError)
                    .WithUserFriendlyMessage(HttpMessageConsts.ServerInternalError);
            }
        }
    }
}
