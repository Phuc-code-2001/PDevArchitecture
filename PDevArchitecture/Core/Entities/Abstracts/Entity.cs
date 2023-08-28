using Microsoft.EntityFrameworkCore;
using PDevArchitecture.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PDevArchitecture.Core.Entities.Abstracts
{
    public abstract class Entity<TPrimary> : IEntity<TPrimary>
    {
        [Key]
        public TPrimary? Id { get; set; }
    }

    public class Entity : Entity<Guid>, IEntity
    {

    }
}
