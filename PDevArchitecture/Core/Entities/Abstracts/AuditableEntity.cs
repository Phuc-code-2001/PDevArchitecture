using PDevArchitecture.Core.Entities.Interfaces;

namespace PDevArchitecture.Core.Entities.Abstracts
{
    public abstract class AuditableEntity<TPrimary> : Entity<TPrimary>, IEntity<TPrimary>, IHasCreatedTime, IHasModifiedTime, IHasRemovedTime
    {
        public virtual DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual DateTime? LastModifiedAt { get; set; }
        public virtual DateTime? RemovedAt { get; set; }
    }
}
