using PDevArchitecture.Core.Entities.Abstracts;

namespace PDevArchitecture.EntityFramework.Entities
{
    public class Employee : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Avatar { get; set; }
    }
}
