using System.Collections.Specialized;
using System.Net;

namespace Bol.OpenAPI.Util
{
    internal static class CheckoutRequestBuilder
    {
        public static HttpWebRequest ConstructBasketRequest(string apiKey, string sessionId)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/checkout/v4/baskets/" + queryString);
            request.Method = "GET";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructBasketAddItemRequest(string apiKey, string sessionId, string offerId, int quantity, string ipAddress)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/checkout/v4/baskets/" + offerId + "/" + quantity + "/" + ipAddress + "/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructBasketChangeItemQuantityRequest(string apiKey, string sessionId, string basketItemId, int quantity)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/checkout/v4/baskets/" + basketItemId + "/" + quantity + "/" + queryString);
            request.Method = "PUT";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructBasketRemoveItemQuantityRequest(string apiKey, string sessionId, string basketItemId)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/checkout/v4/baskets/" + basketItemId + "/" + queryString);
            request.Method = "DELETE";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }
    }
}
