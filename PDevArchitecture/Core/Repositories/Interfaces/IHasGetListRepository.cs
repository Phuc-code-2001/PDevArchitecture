
namespace PDevArchitecture.Core.Repositories.Interfaces
{
    public interface IHasGetListRepository<TEntity>
    {
        IQueryable<TEntity> GetList(bool tracked = false);
    }
}
