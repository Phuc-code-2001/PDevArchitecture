using Microsoft.EntityFrameworkCore;
using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.EntityFramework.Repositories.Interfaces;

namespace PDevArchitecture.EntityFramework.Repositories
{
    public class CRUDRepository<TEntity, TPrimary> :
        ICRUDRepository<TEntity, TPrimary>
        where TEntity : BaseEntity<TPrimary>
    {

        protected readonly ICommandRepository<TEntity, TPrimary> _command;
        protected readonly IQueryRepository<TEntity, TPrimary> _query;

        public CRUDRepository(ICommandRepository<TEntity, TPrimary> command, IQueryRepository<TEntity, TPrimary> query)
        {
            _command = command;
            _query = query;
        }

        public TEntity Create(TEntity entity)
        {
            return _command.Create(entity);
        }
        public TEntity Update(TEntity entity)
        {
            return _command.Update(entity);
        }

        public bool Delete(TEntity entity, bool permanent = false)
        {
            return _command.Delete(entity, permanent);
        }

        public TEntity? Get(TPrimary Id, bool tracked = false)
        {
            return _query.Get(Id, tracked);
        }

        public IQueryable<TEntity> GetList(bool tracked = false)
        {
            return _query.GetList(tracked);
        }

    }
}
