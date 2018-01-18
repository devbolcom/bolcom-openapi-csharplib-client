using System.Net;

namespace Bol.OpenAPI.Exception
{
    public class BasicApiException : System.ApplicationException
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Status { get; set; }

        public BasicApiException() { }

        public BasicApiException(HttpStatusCode statusCode, string status, string message) : base(message)
        {
            StatusCode = statusCode;
            Status = status;
        }

        public override string ToString()
        {
            return $"[{StatusCode} {Status} {Message}]";
        }
    }
}
