using System.Net;

namespace PDevArchitecture.Application.Shared.Exceptions
{
    public class HttpResponseException : Exception
    {
        public Exception? BaseException { get; set; }
        public int StatusCode { get; set; }
        public string? UserFriendlyMessage { get; set; }

        public HttpResponseException FromBase(Exception ex)
        {
            BaseException = ex;
            return this;
        }

        public HttpResponseException WithStatusCode(int statusCode)
        {
            StatusCode = statusCode;
            return this;
        }

        public HttpResponseException WithUserFriendlyMessage(string message)
        {
            UserFriendlyMessage = message;
            return this;
        }

    }
}
