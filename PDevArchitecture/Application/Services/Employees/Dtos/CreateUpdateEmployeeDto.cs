using System.ComponentModel.DataAnnotations;

namespace PDevArchitecture.Application.Services.Employees.Dtos
{
    public class CreateUpdateEmployeeDto
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
        public IFormFile? Avatar { get; set; }
    }
}
