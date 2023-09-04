using Microsoft.AspNetCore.Mvc;
using PDevArchitecture.Application.Shared.Interfaces.Paging;

namespace PDevArchitecture.Application.Shared.Interfaces.Controllers
{
    public interface IHasPagingController<TPagingRequest>
        where TPagingRequest : IPagingRequest
    {
        IActionResult GetList(TPagingRequest paging);
    }
}
