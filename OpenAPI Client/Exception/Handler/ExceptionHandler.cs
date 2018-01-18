using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;

namespace Bol.OpenAPI.Exception.Handler
{
    class ExceptionHandler
    {
        public static BasicApiException HandleBasicApiException(HttpWebResponse response)
        {
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string responseString = reader.ReadToEnd();
                Error error = JsonConvert.DeserializeObject<Error>(responseString);
                return new BasicApiException(response.StatusCode, error.Code, error.Message);
            }            
        }
    }
}
