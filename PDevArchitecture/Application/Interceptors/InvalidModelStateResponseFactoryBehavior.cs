using Microsoft.AspNetCore.Mvc;
using PDevArchitecture.Application.Shared.Protocols;
using PDevArchitecture.Extensions;

namespace PDevArchitecture.Application.Interceptors
{
    public class InvalidModelStateResponseFactoryBehavior
    {
        public IActionResult Handler(ActionContext context)
        {
            HttpErrorResponse errorResponse = new HttpErrorResponse()
                .WithMessage("One or more fields not validated.");

            var errors = context.ModelState.Select(x => new
            {
                x.Key,
                x.Value!.Errors
            });

            foreach (var err in errors)
            {
                foreach (var msg in err.Errors)
                {
                    errorResponse.WithDetail(err.Key, msg.ErrorMessage);
                }
            }

            return new BadRequestObjectResult(errorResponse);
        }
    }
}
