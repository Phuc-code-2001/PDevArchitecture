using AutoMapper;
using PDevArchitecture.Application.Mappers.Interfaces;
using PDevArchitecture.Demonstrations.Entities;

namespace PDevArchitecture.Demonstrations.Dtos
{
    public class BookCreateAndUpdateDto : IEntityMappingHandler<Book>
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public Book GetMappedObject(IMapper mapper)
        {
            return mapper.Map<Book>(this);
        }
    }
}
