namespace PDevArchitecture.Core.Repositories.Interfaces
{
    public interface IHasUpdateRepository<TEntity>
    {
        TEntity Update(TEntity entity);
    }
}
