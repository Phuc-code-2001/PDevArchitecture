namespace PDevArchitecture.Core.Entities.Interfaces
{
    public interface IHasModifiedTime
    {
        DateTime? LastModifiedAt { get; set; }
    }
}
