namespace PDevArchitecture.Core.Entities.Interfaces
{
    public interface IEntity<TPrimary>
    {
        TPrimary? Id { get; set; }
    }

    public interface IEntity : IEntity<Guid>
    {

    }
}
