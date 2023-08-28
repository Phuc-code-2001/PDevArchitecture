namespace PDevArchitecture.Application.Shared.Interfaces.Filters
{
    public interface IFilterBackend<TEntity>
    {
        IQueryable<TEntity> HandleFilter(IQueryable<TEntity> source);
    }
}
