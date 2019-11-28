namespace Bol.OpenAPI.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using Bol.OpenAPI.Client.Builder;
    using Bol.OpenAPI.Client.Exception.Handler;
    using Bol.OpenAPI.Client.Request.Catalog;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenApiClient
    {
        private readonly string _apiKey;

        public OpenApiClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<Pong> PingAsync()
        {
            var request = UtilsRequestBuilder.ConstructPingRequest(_apiKey);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<Pong>();
        }

        public async Task<SearchResults> SearchAsync(SearchResultsRequest searchResultsRequest)
        {
            var request = CatalogRequestBuilder.ConstructSearchRequest(_apiKey, searchResultsRequest);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<SearchResults>();
        }

        public async Task<ListResults> BrowseAsync(ListResultsRequest listResultsRequest)
        {
            var request = CatalogRequestBuilder.ConstructListRequest(_apiKey, listResultsRequest);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<ListResults>();
        }

        public async Task<ProductList> GetProductsAsync(ProductsRequest productsRequest)
        {
            var request = CatalogRequestBuilder.ConstructProductsRequest(_apiKey, productsRequest);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<ProductList>();
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
        //    return (await ProcessBodylessRequest(request)).ToObject<SellerList>();
        //}

        public async Task<ProductRecommendations> GetProductRecommendationsAsync(ProductRecommendationsRequest productRecommendationsRequest)
        {
            var request = CatalogRequestBuilder.ConstructProductRecommendationsRequest(_apiKey, productRecommendationsRequest);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<ProductRecommendations>();
        }

        public async Task<ProductOffers> GetProductOffersAsync(ProductOffersRequest productOffersRequest)
        {
            var request = CatalogRequestBuilder.ConstructProductOffersRequest(_apiKey, productOffersRequest);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<ProductOffers>();
        }

        public async Task<RelatedProducts> GetRelatedProductsAsync(RelatedProductsRequest relatedProductsRequest)
        {
            var request = CatalogRequestBuilder.ConstructRelatedProductsRequest(_apiKey, relatedProductsRequest);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<RelatedProducts>();
        }

        public async Task<Session> GetSessionAsync()
        {
            var request = AccountsRequestBuilder.ConstructSessionRequest(_apiKey);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<Session>();
        }

        public async Task<RequestAuthToken> GetRequestAuthTokenAsync(string successUrl, string errorUrl)
        {
            var request = AccountsRequestBuilder.ConstructAuthTokenRequest(_apiKey, successUrl, errorUrl);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<RequestAuthToken>();
        }

        public async Task<Login> LoginAsync(string privateToken, string sessionId)
        {
            var request = AccountsRequestBuilder.ConstructLoginRequest(_apiKey, privateToken, sessionId);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<Login>();
        }

        public async Task LogoutAsync(string sessionId)
        {
            var request = AccountsRequestBuilder.ConstructLogoutRequest(_apiKey, sessionId);
            await ProcessBodylessRequestAsync(request, false).ConfigureAwait(false);
        }

        public async Task<WishList> GetWishListAsync(string sessionId)
        {
            var request = AccountsRequestBuilder.ConstructWishListRequest(_apiKey, sessionId);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<WishList>();
        }

        public async Task AddItemToWishListAsync(string sessionId, string productId)
        {
            var request = AccountsRequestBuilder.ConstructWishListAddItemRequest(_apiKey, sessionId, productId);
            await ProcessBodylessRequestAsync(request, false).ConfigureAwait(false);
        }

        public async Task RemoveItemFromWishListAsync(string sessionId, string wishListItemId)
        {
            var request = AccountsRequestBuilder.ConstructWishListRemoveItemRequest(_apiKey, sessionId, wishListItemId);
            await ProcessBodylessRequestAsync(request, false).ConfigureAwait(false);
        }

        public async Task<Basket> GetBasketAsync(string sessionId)
        {
            var request = CheckoutRequestBuilder.ConstructBasketRequest(_apiKey, sessionId);
            return (await ProcessBodylessRequestAsync(request).ConfigureAwait(false)).ToObject<Basket>();
        }

        public async Task AddItemToBasketAsync(string sessionId, string offerId, int quantity, string ipAddress)
        {
            var request = CheckoutRequestBuilder.ConstructBasketAddItemRequest(_apiKey, sessionId, offerId, quantity, ipAddress);
            await ProcessBodylessRequestAsync(request, false).ConfigureAwait(false);
        }

        public async Task ChangeItemQuantityInBasketAsync(string sessionId, string basketItemId, int quantity)
        {
            var request = CheckoutRequestBuilder.ConstructBasketChangeItemQuantityRequest(_apiKey, sessionId, basketItemId, quantity);
            await ProcessBodylessRequestAsync(request, false).ConfigureAwait(false);
        }

        public async Task RemoveItemFromBasketAsync(string sessionId, string basketItemId)
        {
            var request = CheckoutRequestBuilder.ConstructBasketRemoveItemQuantityRequest(_apiKey, sessionId, basketItemId);
            await ProcessBodylessRequestAsync(request, false).ConfigureAwait(false);
        }

        private static async Task<JObject> ProcessBodylessRequestAsync(HttpWebRequest request, bool parseBody = true)
        {
            JObject o = null;

            HttpWebResponse response = null;
            try
            {
                request.UserAgent = "bol.com API/4.0, 51c#_,,^..^,,_";
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                response = (HttpWebResponse)await request
                    .GetResponseAsync()
                    .ConfigureAwait(false);

                if (HttpStatusCode.OK == response.StatusCode && parseBody)
                {
                    using var stream = response.GetResponseStream();
                    var reader = new StreamReader(stream ?? throw new InvalidOperationException(), Encoding.UTF8);
                    var responseString = reader.ReadToEnd();
                    o = JsonConvert.DeserializeObject<JObject>(responseString);
                }
            }
            catch (WebException e) when (e.Response != null)
            {
                response = (HttpWebResponse)e.Response;
                throw ExceptionHandler.HandleBasicApiException(response);
            }
            finally
            {
                response?.Close();
            }

            return o;
        }
    }
}
