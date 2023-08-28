using Microsoft.AspNetCore.Mvc;

namespace PDevArchitecture.Application.Shared.Interfaces.Controllers
{
    public interface IHasPagingController<TPagingRequest>
    {
        IActionResult GetList(TPagingRequest paging);
    }
}
