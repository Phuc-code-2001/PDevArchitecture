using AutoMapper;

namespace PDevArchitecture.Application.Mappers.Interfaces
{
    public interface IEntityMappingHandler<TDesination>
    {
        TDesination GetMappedObject(IMapper mapper);
    }
}
