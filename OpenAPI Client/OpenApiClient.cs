using Bol.OpenAPI.Exception.Handler;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;

namespace Bol.OpenAPI.Client
{
    public class OpenApiClient
    {
        private readonly string apiKey;
        private readonly IWebProxy proxy;

        public OpenApiClient(string apiKey, IWebProxy proxy = null)
        {
            this.apiKey = apiKey;
            this.proxy = proxy;
        }

        public Pong Ping()
        {
            HttpWebRequest request = UtilsRequestBuilder.ConstructPingRequest(apiKey);
            Pong pong = ProcessBodylessRequest(request).ToObject<Pong>();

            return pong;
        }

        public SearchResults Search(SearchResultsRequest searchResultsRequest)
        {
            HttpWebRequest request = CatalogRequestBuilder.ConstructSearchRequest(apiKey, searchResultsRequest);
            SearchResults searchResults = ProcessBodylessRequest(request).ToObject<SearchResults>();

            return searchResults;
        }

        public ListResults Browse(ListResultsRequest listResultsRequest)
        {
            HttpWebRequest request = CatalogRequestBuilder.ConstructListRequest(apiKey, listResultsRequest);
            ListResults listResults = ProcessBodylessRequest(request).ToObject<ListResults>();

            return listResults;
        }

        public ProductList GetProducts(ProductsRequest productsRequest)
        {
            HttpWebRequest request = CatalogRequestBuilder.ConstructProductsRequest(apiKey, productsRequest);
            ProductList productList = ProcessBodylessRequest(request).ToObject<ProductList>();

            return productList;
        }

        public SellerList GetSellerList(SellerListRequest sellerListRequest)
        {
            HttpWebRequest request = CatalogRequestBuilder.ConstructSellerListRequest(apiKey, sellerListRequest);
            SellerList sellerList = ProcessBodylessRequest(request).ToObject<SellerList>();

            return sellerList;
        }

        public ProductRecommendations GetProductRecommendations(ProductRecommendationsRequest productRecommendationsRequest)
        {
            HttpWebRequest request = CatalogRequestBuilder.ConstructProductRecommendationsRequest(apiKey, productRecommendationsRequest);
            ProductRecommendations productRecommendations = ProcessBodylessRequest(request).ToObject<ProductRecommendations>();

            return productRecommendations;
        }

        public ProductOffers GetProductOffers(ProductOffersRequest productOffersRequest)
        {
            HttpWebRequest request = CatalogRequestBuilder.ConstructProductOffersRequest(apiKey, productOffersRequest);
            ProductOffers productOffers = ProcessBodylessRequest(request).ToObject<ProductOffers>();

            return productOffers;
        }

        public RelatedProducts GetRelatedProducts(RelatedProductsRequest relatedProductsRequest)
        {
            HttpWebRequest request = CatalogRequestBuilder.ConstructRelatedProductsRequest(apiKey, relatedProductsRequest);
            RelatedProducts relatedProducts = ProcessBodylessRequest(request).ToObject<RelatedProducts>();

            return relatedProducts;
        }

        public Session GetSession()
        {
            HttpWebRequest request = AccountsRequestBuilder.ConstructSessionRequest(apiKey);
            Session session = ProcessBodylessRequest(request).ToObject<Session>();

            return session;
        }

        public RequestAuthToken GetRequestAuthToken(string successUrl, string errorUrl)
        {
            HttpWebRequest request = AccountsRequestBuilder.ConstructAuthTokenRequest(apiKey, successUrl, errorUrl);
            RequestAuthToken requestAuthToken = ProcessBodylessRequest(request).ToObject<RequestAuthToken>();

            return requestAuthToken;
        }

        public Login Login(string privateToken, string sessionId)
        {
            HttpWebRequest request = AccountsRequestBuilder.ConstructLoginRequest(apiKey, privateToken, sessionId);
            Login login = ProcessBodylessRequest(request).ToObject<Login>();
            
            return login;
        }

        public void Logout(string sessionId)
        {
            HttpWebRequest request = AccountsRequestBuilder.ConstructLogoutRequest(apiKey, sessionId);
            ProcessBodylessRequest(request, false);
        }

        public WishList GetWishList(string sessionId)
        {
            HttpWebRequest request = AccountsRequestBuilder.ConstructWishListRequest(apiKey, sessionId);
            WishList wishList = ProcessBodylessRequest(request).ToObject<WishList>();

            return wishList;
        }

        public void AddItemToWishList(string sessionId, string productId)
        {
            HttpWebRequest request = AccountsRequestBuilder.ConstructWishListAddItemRequest(apiKey, sessionId, productId);
            ProcessBodylessRequest(request, false);
        }

        public void RemoveItemFromWishList(string sessionId, string wishListItemId)
        {
            HttpWebRequest request = AccountsRequestBuilder.ConstructWishListRemoveItemRequest(apiKey, sessionId, wishListItemId);
            ProcessBodylessRequest(request, false);
        }

        public Basket GetBasket(string sessionId)
        {
            HttpWebRequest request = CheckoutRequestBuilder.ConstructBasketRequest(apiKey, sessionId);
            Basket basket = ProcessBodylessRequest(request).ToObject<Basket>();

            return basket;
        }

        public void AddItemToBasket(string sessionId, string offerId, int quantity, string ipAddress)
        {
            HttpWebRequest request = CheckoutRequestBuilder.ConstructBasketAddItemRequest(apiKey, sessionId, offerId, quantity, ipAddress);
            ProcessBodylessRequest(request, false);
        }

        public void ChangeItemQuantityInBasket(string sessionId, string basketItemId, int quantity)
        {
            HttpWebRequest request = CheckoutRequestBuilder.ConstructBasketChangeItemQuantityRequest(apiKey, sessionId, basketItemId, quantity);
            ProcessBodylessRequest(request, false);
        }

        public void RemoveItemFromBasket(string sessionId, string basketItemId)
        {
            HttpWebRequest request = CheckoutRequestBuilder.ConstructBasketRemoveItemQuantityRequest(apiKey, sessionId, basketItemId);
            ProcessBodylessRequest(request, false);
        }

        private JObject ProcessBodylessRequest(HttpWebRequest request)
        {
            return ProcessBodylessRequest(request, true);
        }

        private JObject ProcessBodylessRequest(HttpWebRequest request, bool parseBody)
        {
            JObject o = null;

            HttpWebResponse response = null;
            try
            {
                if (proxy != null)
                {
                    request.Proxy = proxy;
                }
                request.UserAgent = "bol.com API/4.0, 51c#_,,^..^,,_";
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                response = (HttpWebResponse)request.GetResponse();
                if (HttpStatusCode.OK == response.StatusCode && parseBody)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                        string responseString = reader.ReadToEnd();
                        o = JsonConvert.DeserializeObject<JObject>(responseString);                        
                    }
                }
            }
            catch (WebException e)
            {
                if (e.Response != null)
                {
                    response = (HttpWebResponse)e.Response;
                    throw ExceptionHandler.HandleBasicApiException(response);
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }

            return o;
        }
    }
}
