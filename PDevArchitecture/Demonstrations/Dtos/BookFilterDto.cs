using PDevArchitecture.Application.Shared.Interfaces.Filters;
using PDevArchitecture.Demonstrations.Entities;
using PDevArchitecture.Extensions;

namespace PDevArchitecture.Demonstrations.Dtos
{
    public class BookFilterDto : Book, IFilterBackend<Book>
    {
        public IQueryable<Book> HandleFilter(IQueryable<Book> source)
        {
            return source
                .WhereIf(Title != null, entity => entity.Title != null && entity.Title!.Contains(Title!))
                .WhereIf(Description != null, entity => entity.Description != null && entity.Description!.Contains(Description!));
        }
    }
}
