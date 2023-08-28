using Microsoft.AspNetCore.Mvc;

namespace PDevArchitecture.Application.Shared.Interfaces.Controllers
{
    public interface IHasCreationController<TCreateDto>
    {
        IActionResult Create(TCreateDto data);
    }
}
