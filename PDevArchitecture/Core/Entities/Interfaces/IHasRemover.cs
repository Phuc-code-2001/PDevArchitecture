namespace PDevArchitecture.Core.Entities.Interfaces
{
    public interface IHasRemover<TUser>
    {
        TUser? Remover { get; set; }
    }
}
