using System;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;

namespace Bol.OpenAPI.Exception.Handler
{
    internal static class ExceptionHandler
    {
        public static BasicApiException HandleBasicApiException(HttpWebResponse response)
        {
            using (var stream = response.GetResponseStream())
            {
                var reader = new StreamReader(stream ?? throw new InvalidOperationException(), Encoding.UTF8);
                var responseString = reader.ReadToEnd();
                var error = JsonConvert.DeserializeObject<Error>(responseString);
                return new BasicApiException(error.Code, error.Message);
            }
        }
    }
}
