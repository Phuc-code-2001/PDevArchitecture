using AutoMapper;
using PDevArchitecture.Demonstrations.Dtos;
using PDevArchitecture.Demonstrations.Entities;

namespace PDevArchitecture.Application.Mappers
{
    public class CommonMapperProfile : Profile
    {

        public CommonMapperProfile()
        {
            CreateMap<BookCreateAndUpdateDto, Book>();
        }
    }
}
