namespace PDevArchitecture.Core.Repositories.Interfaces
{
    public interface IHasCreateRepository<TEntity>
    {
        TEntity Create(TEntity entity);
    }
}
