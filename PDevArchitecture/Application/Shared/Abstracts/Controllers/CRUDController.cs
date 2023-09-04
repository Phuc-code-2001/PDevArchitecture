using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDevArchitecture.Application.Mappers.Helpers;
using PDevArchitecture.Application.Mappers.Interfaces;
using PDevArchitecture.Application.Shared.Interfaces.Controllers;
using PDevArchitecture.Application.Shared.Interfaces.Filters;
using PDevArchitecture.Core.Entities.Abstracts;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;
using PDevArchitecture.Extensions;

namespace PDevArchitecture.Application.Shared.Abstracts.Controllers
{
    
    public abstract class CRUDController<TEntity, TFilter, TPrimary, TCreateDto, TUpdateDto> : ControllerBase,
        ICRUDController<TFilter, TPrimary, TCreateDto, TUpdateDto>
        where TEntity : BaseEntity<TPrimary>
        where TFilter : IFilterBackend<TEntity>
        where TCreateDto : IEntityMappingHandler<TEntity>
    {

        protected IEfCoreRepository<TEntity, TPrimary> _repository;
        protected EntityMapper _entityMapper;

        protected CRUDController(IEfCoreRepository<TEntity, TPrimary> repository, EntityMapper entityMapper)
        {
            _repository = repository;
            _entityMapper = entityMapper;
        }

        [HttpPost]
        public IActionResult Create(TCreateDto data)
        {
            return TryCatchExtentionMethods.TryAndCatchAPIControllerException(this, () =>
            {
                TEntity entity = _entityMapper.MapToEntity<TCreateDto, TEntity>(data);
                _repository.EntitySet.Add(entity);
                _repository.DbContext.SaveChanges();
                return Ok(entity);
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(TPrimary id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult Get(TPrimary id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult GetList(TFilter filter)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult Update(TPrimary id, TUpdateDto data)
        {
            throw new NotImplementedException();
        }
    }
}
