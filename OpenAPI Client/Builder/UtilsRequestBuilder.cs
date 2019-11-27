﻿using System.Collections.Specialized;
using System.Net;

namespace Bol.OpenAPI.Util
{
    internal static class UtilsRequestBuilder
    {
        public static HttpWebRequest ConstructPingRequest(string apiKey)
        {
            var queryParams = new NameValueCollection
            {
                { "apikey", apiKey }
            };
            var queryString = HttpUtils.ToQueryString(queryParams);

            var request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/utils/v4/ping/" + queryString);
            request.Method = "GET";
            request.Accept = "application/json";

            return request;
        }
    }
}
