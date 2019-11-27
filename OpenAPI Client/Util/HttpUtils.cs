using System;
using System.Collections.Specialized;
using System.Net;
using System.Web;

namespace Bol.OpenAPI.Util
{
    internal static class HttpUtils
    {
        public static string ToQueryString(NameValueCollection nvc)
        {
            if (nvc?.Count > 0)
            {
                // Does not support multi-value parameters, but for now we can accept that
                return "?" + string.Join("&", Array.ConvertAll(nvc.AllKeys, key =>
                           $"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(nvc[key])}"));
            }

            return "";
        }

        public static void AddSessionHeader(HttpWebRequest request, string sessionId)
        {
            if (sessionId != null)
            {
                request.Headers.Add("X-OpenAPI-Session-ID", sessionId);
            }
        }
    }
}
