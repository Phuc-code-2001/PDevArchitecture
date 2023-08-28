namespace PDevArchitecture.Core.Entities.Interfaces
{
    public interface IHasModifier<TUser>
    {
        TUser? LastModifier { get; set; }
    }
}
