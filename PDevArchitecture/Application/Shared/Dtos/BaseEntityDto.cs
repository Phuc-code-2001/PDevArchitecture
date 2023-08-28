namespace PDevArchitecture.Application.Shared.Dtos
{
    public class BaseEntityDto<TPrimary>
    {
        public TPrimary? Id { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime? LastModifiedAt { get; set; }
        public virtual DateTime? RemovedAt { get; set; }
        public bool IsActive { get; set; }
    }

    public class BaseEntityDto<TPrimary, TUser> : BaseEntityDto<TPrimary>
    {
        public TUser? Creator { get; set; }
        public TUser? LastModifier { get; set; }
        public TUser? Remover { get; set; }
    }

    public class BaseEntityDto : BaseEntityDto<Guid>
    {

    }
}
