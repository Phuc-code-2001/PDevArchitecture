namespace PDevArchitecture.Core.Entities.Interfaces
{
    public interface IHasCreator<TUser>
    {
        TUser? Creator { get; set; }
    }
}
