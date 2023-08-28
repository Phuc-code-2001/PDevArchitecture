using Microsoft.AspNetCore.Mvc;

namespace PDevArchitecture.Application.Shared.Interfaces.Controllers
{
    public interface IHasRetrieveController<TPrimary>
    {
        IActionResult Get(TPrimary id);
    }
}
