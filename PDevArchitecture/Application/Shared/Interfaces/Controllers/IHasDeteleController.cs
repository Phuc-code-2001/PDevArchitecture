using Microsoft.AspNetCore.Mvc;

namespace PDevArchitecture.Application.Shared.Interfaces.Controllers
{
    public interface IHasDeteleController<TPrimary>
    {
        IActionResult Delete(TPrimary id);
    }
}
