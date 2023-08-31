using PDevArchitecture.Core.Entities.Abstracts;

namespace PDevArchitecture.Demonstrations.Entities
{
    public class Book : BaseEntity<int>
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
