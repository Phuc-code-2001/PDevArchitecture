namespace PDevArchitecture.Core.Entities.Interfaces
{
    public interface IBaseEntity<TPrimary>
        : IEntity<TPrimary>, IHasCreatedTime, IHasModifiedTime, IHasRemovedTime, IHasActiveEntity
    {

    }

    public interface IBaseEntity<TPrimary, TUser>
        : IBaseEntity<TPrimary>, IHasCreator<TUser>, IHasModifier<TUser>, IHasRemover<TUser>
    {

    }
}
