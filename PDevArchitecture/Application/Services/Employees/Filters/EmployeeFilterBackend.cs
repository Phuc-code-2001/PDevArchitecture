using PDevArchitecture.Application.Shared.Interfaces.Filters;
using PDevArchitecture.EntityFramework.Entities;
using PDevArchitecture.Extensions;

namespace PDevArchitecture.Application.Services.Employees.Filters
{
    public class EmployeeFilterBackend : IFilterBackend<Employee>
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }

        public IQueryable<Employee> HandleFilter(IQueryable<Employee> source)
        {

            var queryable = source.WhereIf(Id != null, (emp) => emp.Id.ToString().Contains(Id!))
                                  .WhereIf(FirstName != null, (emp) => emp.FirstName!.Contains(FirstName!))
                                  .WhereIf(LastName != null, (emp) => emp.LastName!.Contains(LastName!))
                                  .WhereIf(BirthDate != null, (emp) => emp.BirthDate! == BirthDate!);

            return queryable;
        }
    }
}
