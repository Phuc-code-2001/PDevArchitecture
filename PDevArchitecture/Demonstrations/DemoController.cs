using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDevArchitecture.Application.Mappers.Helpers;
using PDevArchitecture.Application.Shared.Abstracts.Controllers;
using PDevArchitecture.Demonstrations.Dtos;
using PDevArchitecture.Demonstrations.Entities;
using PDevArchitecture.EntityFrameworkCore.Repositories;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;

namespace PDevArchitecture.Demonstrations
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : CRUDController<Book, BookFilterDto, int, BookCreateAndUpdateDto, BookCreateAndUpdateDto>
    {
        public DemoController(IEfCoreRepository<Book, int> repository, EntityMapper entityMapper) 
            : base(repository, entityMapper)
        {

        }
    }
}
