using PDevArchitecture.Application.Shared.Protocols;

namespace PDevArchitecture.Extensions
{
    public static class HttpResponseExtensionMethods
    {
        public static HttpSuccessResponse WithMessage(this HttpSuccessResponse response, string message)
        {
            response.Message = message;
            return response;
        }
        public static HttpSuccessResponse WithData(this HttpSuccessResponse response, object data)
        {
            response.Data = data;
            return response;
        }
        public static HttpErrorResponse WithMessage(this HttpErrorResponse response, string message)
        {
            response.Message = message;
            return response;
        }
        public static HttpErrorResponse WithDetail(this HttpErrorResponse response, string key, string value)
        {
            response.Details.Add(new KeyValuePair<string, string?>(key, value));
            return response;
        }

    }
}
