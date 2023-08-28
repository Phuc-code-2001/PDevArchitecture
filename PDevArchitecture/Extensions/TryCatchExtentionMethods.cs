using Microsoft.AspNetCore.Mvc;
using PDevArchitecture.Application.Shared.Consts;
using PDevArchitecture.Application.Shared.Exceptions;
using PDevArchitecture.Application.Shared.Protocols;

namespace PDevArchitecture.Extensions
{
    public static class TryCatchExtentionMethods
    {
        public static IActionResult RunAndCatchHttpException(
            this ControllerBase controller, Func<IActionResult> func)
        {
            try
            {
                return func();
            }
            catch (HttpResponseException ex)
            {
                HttpErrorResponse response = new HttpErrorResponse()
                    .WithMessage(ex.UserFriendlyMessage ?? string.Empty)
                    .WithDetail("Function", nameof(func));
                return controller.StatusCode(ex.StatusCode, response);
            }
            catch (Exception)
            {
                HttpErrorResponse response = new HttpErrorResponse()
                    .WithMessage(HttpMessageConsts.ServerInternalError)
                    .WithDetail("Function", nameof(func));
                return controller.StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }
}
