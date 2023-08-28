namespace PDevArchitecture.Core.Repositories.Interfaces
{
    public interface IHasDeleteRepository<TEntity>
    {
        bool Delete(TEntity entity, bool permanent = false);
    }
}
