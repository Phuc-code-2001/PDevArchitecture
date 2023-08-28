using Microsoft.AspNetCore.Mvc;

namespace PDevArchitecture.Application.Shared.Interfaces.Controllers
{
    public interface IHasListController<TFilter>
    {
        IActionResult GetList(TFilter filter);
    }
}
