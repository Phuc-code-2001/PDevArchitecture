using Microsoft.AspNetCore.Mvc;
using PDevArchitecture.Application.Shared.Consts;
using PDevArchitecture.Application.Shared.Exceptions;
using PDevArchitecture.Application.Shared.Protocols;

namespace PDevArchitecture.Extensions
{
    public static class TryCatchExtentionMethods
    {
        public static IActionResult TryAndCatchAPIControllerException(this ControllerBase controller, Func<IActionResult> handler)
        {
            try
            {
                return handler();
            }
            catch(HttpException ex)
            {
                return controller.StatusCode(ex.StatusCode, new HttpErrorResponse()
                {
                    Message = ex.UserFriendlyMessage
                });
            }
            catch(Exception ex)
            {
                return controller.StatusCode(500, new HttpErrorResponse()
                {
                    Message = HttpMessageConsts.UnExpectedError
                }
                .WithDetail("Exception", ex.Message));
            }
        }
    }
}
