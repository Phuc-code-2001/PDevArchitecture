using Microsoft.AspNetCore.Mvc;

namespace PDevArchitecture.Application.Shared.Interfaces.Controllers
{
    public interface ICRUDController<TFilter, TPrimary, TCreateDto, TUpdateDto> :
        IHasListController<TFilter>,
        IHasRetrieveController<TPrimary>,
        IHasCreationController<TCreateDto>,
        IHasUpdateController<TPrimary, TUpdateDto>,
        IHasDeteleController<TPrimary>
    {

    }
}
