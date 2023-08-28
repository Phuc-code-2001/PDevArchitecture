using PDevArchitecture.Core.Entities.Interfaces;

namespace PDevArchitecture.Core.Entities.Abstracts
{
    public abstract class HasMonitoringEntity<TPrimary, TUser> : AuditableEntity<TPrimary>, IHasCreator<TUser>, IHasModifier<TUser>, IHasRemover<TUser>
    {
        public TUser? Creator { get; set; }
        public TUser? LastModifier { get; set; }
        public TUser? Remover { get; set; }
    }
}
