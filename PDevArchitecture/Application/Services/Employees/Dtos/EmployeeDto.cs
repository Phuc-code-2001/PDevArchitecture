using PDevArchitecture.Application.Shared.Dtos;

namespace PDevArchitecture.Application.Services.Employees.Dtos
{
    public class EmployeeDto : BaseEntityDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Avatar { get; set; }
    }
}
