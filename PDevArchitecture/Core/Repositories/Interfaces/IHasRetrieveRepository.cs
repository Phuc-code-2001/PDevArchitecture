namespace PDevArchitecture.Core.Repositories.Interfaces
{
    public interface IHasRetrieveRepository<TEntity, TPrimary>
    {
        TEntity? Get(TPrimary Id, bool tracked = false);
    }
}
