namespace Bol.OpenAPI.Client.Builder
{
    using System.Collections.Specialized;
    using System.Net;
    using Bol.OpenAPI.Client.Util;

    internal static class AccountsRequestBuilder
    {
        public static HttpWebRequest ConstructSessionRequest(string apiKey)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };
            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/sessions/" + queryString);
            request.Method = "GET";
            request.Accept = "application/json";

            return request;
        }

        public static HttpWebRequest ConstructAuthTokenRequest(string apiKey, string successUrl, string errorUrl)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            if (successUrl != null)
            {
                queryParams.Add("successurl", successUrl);
            }
            if (errorUrl != null)
            {
                queryParams.Add("errorUrl", errorUrl);
            }

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/authtokens/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";

            return request;
        }

        public static HttpWebRequest ConstructLoginRequest(string apiKey, string privateToken, string sessionId)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            if (privateToken != null)
            {
                queryParams.Add("privatetoken", privateToken);
            }

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/login/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructLogoutRequest(string apiKey, string sessionId)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/logout/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructWishListRequest(string apiKey, string sessionId)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/wishlists/" + queryString);
            request.Method = "GET";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructWishListAddItemRequest(string apiKey, string sessionId, string productId)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/wishlists/" + productId + "/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructWishListRemoveItemRequest(string apiKey, string sessionId, string wishListItemId)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };

            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/wishlists/" + wishListItemId + "/" + queryString);
            request.Method = "DELETE";
            request.Accept = "application/json";
            HttpUtils.AddSessionHeader(request, sessionId);

            return request;
        }
    }
}
