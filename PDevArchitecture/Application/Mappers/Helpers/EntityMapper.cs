using AutoMapper;
using PDevArchitecture.Application.Mappers.Interfaces;

namespace PDevArchitecture.Application.Mappers.Helpers
{
    public class EntityMapper
    {
        private readonly IMapper _mapper;

        public EntityMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDesination MapToEntity<TSource, TDesination>(TSource source)
            where TSource : IEntityMappingHandler<TDesination> 
        {
            return source.GetMappedObject(_mapper);
        }

    }
}
