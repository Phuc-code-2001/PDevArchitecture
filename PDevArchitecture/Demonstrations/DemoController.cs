using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDevArchitecture.Demonstrations.Entities;
using PDevArchitecture.EntityFrameworkCore.Repositories;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;

namespace PDevArchitecture.Demonstrations
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IEfCoreRepository<Book, int> _repository;

        public DemoController(EfCoreRepository<Book, int> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dataset = (await _repository.GetAsQueryable()).ToList();
            return Ok(dataset);
        }
    }
}
