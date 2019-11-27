namespace Bol.OpenAPI.Exception
{
    public class BasicApiException
        : System.ApplicationException
    {
        public string Status { get; set; }

        public BasicApiException() { }

        public BasicApiException(string status, string message)
            : base(message)
        {
            Status = status;
        }

        public BasicApiException(string message)
            : base(message)
        {
        }

        public BasicApiException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
