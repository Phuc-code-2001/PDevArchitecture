using System.Net;

namespace PDevArchitecture.Application.Shared.Exceptions
{
    public class HttpException : Exception
    {
        public Exception? BaseException { get; set; }
        public int StatusCode { get; set; }
        public string? UserFriendlyMessage { get; set; }

        public HttpException FromBase(Exception ex)
        {
            BaseException = ex;
            return this;
        }

        public HttpException WithStatusCode(int statusCode)
        {
            StatusCode = statusCode;
            return this;
        }

        public HttpException WithUserFriendlyMessage(string message)
        {
            UserFriendlyMessage = message;
            return this;
        }

    }
}
