using AutoMapper;
using PDevArchitecture.Application.Services.Employees.Dtos;
using PDevArchitecture.EntityFramework.Entities;

namespace PDevArchitecture.Application.Mappers
{
    public class CommonMapperProfile : Profile
    {

        public CommonMapperProfile()
        {
            #region Employee
            CreateMap<CreateUpdateEmployeeDto, Employee>()
                .ForMember(dst => dst.Avatar, option =>
                {
                    option.Ignore();
                });

            CreateMap<Employee, EmployeeDto>()
            .ForMember(dst => dst.Avatar, option =>
            {
                option.Ignore();
            });
            #endregion
        }
    }
}
