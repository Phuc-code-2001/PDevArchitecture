using Microsoft.AspNetCore.Mvc;

namespace PDevArchitecture.Application.Shared.Interfaces.Controllers
{
    public interface IHasUpdateController<TPrimary, TUpdateDto>
    {
        IActionResult Update(TPrimary id, TUpdateDto data);
    }
}
