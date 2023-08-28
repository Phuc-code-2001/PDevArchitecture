using PDevArchitecture.Core.Entities.Interfaces;

namespace PDevArchitecture.Core.Entities.Abstracts
{
    public class BaseEntity<TPrimary> : AuditableEntity<TPrimary>, IBaseEntity<TPrimary>
    {
        public bool IsActive { get; set; }
    }

    public class BaseEntity<TPrimary, TUser> : HasMonitoringEntity<TPrimary, TUser>, IBaseEntity<TPrimary, TUser>
    {
        public bool IsActive { get; set; }
    }

    public class BaseEntity : BaseEntity<Guid>
    {

    }
}
