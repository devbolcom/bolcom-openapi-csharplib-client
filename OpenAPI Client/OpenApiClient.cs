using System;
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
        private readonly string _apiKey;

        public OpenApiClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public Pong Ping()
        {
            var request = UtilsRequestBuilder.ConstructPingRequest(_apiKey);
            return ProcessBodylessRequest(request).ToObject<Pong>();
        }

        public SearchResults Search(SearchResultsRequest searchResultsRequest)
        {
            var request = CatalogRequestBuilder.ConstructSearchRequest(_apiKey, searchResultsRequest);
            return ProcessBodylessRequest(request).ToObject<SearchResults>();
        }

        public ListResults Browse(ListResultsRequest listResultsRequest)
        {
            var request = CatalogRequestBuilder.ConstructListRequest(_apiKey, listResultsRequest);
            return ProcessBodylessRequest(request).ToObject<ListResults>();
        }

        public ProductList GetProducts(ProductsRequest productsRequest)
        {
            var request = CatalogRequestBuilder.ConstructProductsRequest(_apiKey, productsRequest);
            return ProcessBodylessRequest(request).ToObject<ProductList>();
        }

        ///// <summary>
        ///// Gets the seller list.
        ///// </summary>
        ///// <param name="sellerListRequest">The seller list request.</param>
        ///// <returns></returns>
        ///// <remarks>API end-point does not exist</remarks>
        //public SellerList GetSellerList(SellerListRequest sellerListRequest)
        //{
        //    var request = CatalogRequestBuilder.ConstructSellerListRequest(_apiKey, sellerListRequest);
        //    return ProcessBodylessRequest(request).ToObject<SellerList>();
        //}

        public ProductRecommendations GetProductRecommendations(ProductRecommendationsRequest productRecommendationsRequest)
        {
            var request = CatalogRequestBuilder.ConstructProductRecommendationsRequest(_apiKey, productRecommendationsRequest);
            return ProcessBodylessRequest(request).ToObject<ProductRecommendations>();
        }

        public ProductOffers GetProductOffers(ProductOffersRequest productOffersRequest)
        {
            var request = CatalogRequestBuilder.ConstructProductOffersRequest(_apiKey, productOffersRequest);
            return ProcessBodylessRequest(request).ToObject<ProductOffers>();
        }

        public RelatedProducts GetRelatedProducts(RelatedProductsRequest relatedProductsRequest)
        {
            var request = CatalogRequestBuilder.ConstructRelatedProductsRequest(_apiKey, relatedProductsRequest);
            return ProcessBodylessRequest(request).ToObject<RelatedProducts>();
        }

        public Session GetSession()
        {
            var request = AccountsRequestBuilder.ConstructSessionRequest(_apiKey);
            return ProcessBodylessRequest(request).ToObject<Session>();
        }

        public RequestAuthToken GetRequestAuthToken(string successUrl, string errorUrl)
        {
            var request = AccountsRequestBuilder.ConstructAuthTokenRequest(_apiKey, successUrl, errorUrl);
            return ProcessBodylessRequest(request).ToObject<RequestAuthToken>();
        }

        public Login Login(string privateToken, string sessionId)
        {
            var request = AccountsRequestBuilder.ConstructLoginRequest(_apiKey, privateToken, sessionId);
            return ProcessBodylessRequest(request).ToObject<Login>();
        }

        public void Logout(string sessionId)
        {
            var request = AccountsRequestBuilder.ConstructLogoutRequest(_apiKey, sessionId);
            ProcessBodylessRequest(request, false);
        }

        public WishList GetWishList(string sessionId)
        {
            var request = AccountsRequestBuilder.ConstructWishListRequest(_apiKey, sessionId);
            return ProcessBodylessRequest(request).ToObject<WishList>();
        }

        public void AddItemToWishList(string sessionId, string productId)
        {
            var request = AccountsRequestBuilder.ConstructWishListAddItemRequest(_apiKey, sessionId, productId);
            ProcessBodylessRequest(request, false);
        }

        public void RemoveItemFromWishList(string sessionId, string wishListItemId)
        {
            var request = AccountsRequestBuilder.ConstructWishListRemoveItemRequest(_apiKey, sessionId, wishListItemId);
            ProcessBodylessRequest(request, false);
        }

        public Basket GetBasket(string sessionId)
        {
            var request = CheckoutRequestBuilder.ConstructBasketRequest(_apiKey, sessionId);
            return ProcessBodylessRequest(request).ToObject<Basket>();
        }

        public void AddItemToBasket(string sessionId, string offerId, int quantity, string ipAddress)
        {
            var request = CheckoutRequestBuilder.ConstructBasketAddItemRequest(_apiKey, sessionId, offerId, quantity, ipAddress);
            ProcessBodylessRequest(request, false);
        }

        public void ChangeItemQuantityInBasket(string sessionId, string basketItemId, int quantity)
        {
            var request = CheckoutRequestBuilder.ConstructBasketChangeItemQuantityRequest(_apiKey, sessionId, basketItemId, quantity);
            ProcessBodylessRequest(request, false);
        }

        public void RemoveItemFromBasket(string sessionId, string basketItemId)
        {
            var request = CheckoutRequestBuilder.ConstructBasketRemoveItemQuantityRequest(_apiKey, sessionId, basketItemId);
            ProcessBodylessRequest(request, false);
        }

        private static JObject ProcessBodylessRequest(HttpWebRequest request, bool parseBody = true)
        {
            JObject o = null;

            HttpWebResponse response = null;
            try
            {
                request.UserAgent = "bol.com API/4.0, 51c#_,,^..^,,_";
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                response = (HttpWebResponse)request.GetResponse();
                if (HttpStatusCode.OK == response.StatusCode && parseBody)
                {
                    using (var stream = response.GetResponseStream())
                    {
                        var reader = new StreamReader(stream ?? throw new InvalidOperationException(), Encoding.UTF8);
                        var responseString = reader.ReadToEnd();
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
                response?.Close();
            }

            return o;
        }
    }
}
