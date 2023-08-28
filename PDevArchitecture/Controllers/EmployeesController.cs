using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDevArchitecture.Application.Services.Employees.Dtos;
using PDevArchitecture.Application.Services.Employees.Filters;
using PDevArchitecture.Application.Shared.Consts;
using PDevArchitecture.Application.Shared.Interfaces.Controllers;
using PDevArchitecture.Application.Shared.Protocols;
using PDevArchitecture.EntityFramework.Entities;
using PDevArchitecture.EntityFramework.Repositories.Interfaces;
using PDevArchitecture.Extensions;

namespace PDevArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase,
        ICRUDController<EmployeeFilterBackend, Guid, CreateUpdateEmployeeDto, CreateUpdateEmployeeDto>
    {

        private readonly ICRUDRepository<Employee, Guid> _repository;
        private readonly IMapper _mapper;

        public EmployeesController(ICRUDRepository<Employee, Guid> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Create([FromForm] CreateUpdateEmployeeDto data)
        {
            return this.RunAndCatchHttpException(() =>
            {
                Employee employee = _mapper.Map<Employee>(data);
                employee = _repository.Create(employee);
                EmployeeDto dto = _mapper.Map<EmployeeDto>(employee);
                return Ok(dto);
            });
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return this.RunAndCatchHttpException(() =>
            {
                Employee? employee = _repository.Get(id);
                if (employee == null) return NotFound();
                EmployeeDto dto = _mapper.Map<EmployeeDto>(employee);
                return Ok(dto);
            });
        }
        [HttpGet]
        public IActionResult GetList([FromQuery] EmployeeFilterBackend filter)
        {
            return this.RunAndCatchHttpException(() =>
            {
                var queryable = _repository.GetList();
                queryable = filter.HandleFilter(queryable);
                EmployeeDto[] employees = _mapper.Map<EmployeeDto[]>(queryable.ToArray());

                var response = new HttpSuccessResponse()
                .WithMessage(HttpMessageConsts.GetListSucceeded)
                .WithData(employees);
                return Ok(response);
            });
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromForm] CreateUpdateEmployeeDto data)
        {
            return this.RunAndCatchHttpException(() =>
            {
                Employee? employee = _repository.Get(id);
                if (employee == null) return NotFound();
                _mapper.Map(data, employee);
                employee = _repository.Update(employee);
                EmployeeDto dto = _mapper.Map<EmployeeDto>(employee);
                return Ok(dto);
            });
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return this.RunAndCatchHttpException(() =>
            {
                Employee? employee = _repository.Get(id);
                if (employee == null) return NotFound();
                _repository.Delete(employee);
                return Ok();
            });
        }
    }
}
