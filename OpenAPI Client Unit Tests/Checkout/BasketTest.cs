using System.Linq;
using System.Threading.Tasks;
using Bol.OpenAPI.Client;
using Bol.OpenAPI.Client.Request.Catalog;
using Bol.OpenAPI.Client.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class BasketTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public async Task TestGetBasket()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);

            var basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);
        }

        [TestMethod]
        public async Task TestAddItemToBasket()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);

            var basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);

            var productOffersRequest = new ProductOffersRequest
            {
                Id = "1004004012288125",
                Offers = new[] {
                    EnumTypes.OfferType.ALL
                }
            };

            var productOffers = await _client.GetProductOffersAsync(productOffersRequest);
            Assert.IsNotNull(productOffers.OfferData);
            Assert.IsNotNull(productOffers.OfferData.Offers);
            Assert.IsTrue(productOffers.OfferData.Offers.Count > 0);

            await _client.AddItemToBasketAsync(session.SessionId, productOffers.OfferData.Offers.First().Id, 1, "192.168.0.1");

            basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 1);
        }

        [TestMethod]
        public async Task TestChangeItemQuantityInBasket()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);

            var basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);

            var productOffersRequest = new ProductOffersRequest
            {
                Id = "1004004012288125",
                Offers = new[] {
                    EnumTypes.OfferType.ALL
                }
            };

            var productOffers = await _client.GetProductOffersAsync(productOffersRequest);
            Assert.IsNotNull(productOffers.OfferData);
            Assert.IsNotNull(productOffers.OfferData.Offers);
            Assert.IsTrue(productOffers.OfferData.Offers.Count > 0);

            await _client.AddItemToBasketAsync(session.SessionId, productOffers.OfferData.Offers.First().Id, 1, "192.168.0.1");

            basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 1);
            Assert.IsTrue(basket.BasketItems[0].Quantity == 1);

            await _client.ChangeItemQuantityInBasketAsync(session.SessionId, basket.BasketItems[0].Id, 2);

            basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 1);
            Assert.IsTrue(basket.BasketItems[0].Quantity == 2);
        }

        [TestMethod]
        public async Task TestRemoveItemFromBasket()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);

            var basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);

            var productOffersRequest = new ProductOffersRequest
            {
                Id = "1004004012288125",
                Offers = new[] {
                    EnumTypes.OfferType.ALL
                }
            };

            var productOffers = await _client.GetProductOffersAsync(productOffersRequest);
            Assert.IsNotNull(productOffers.OfferData);
            Assert.IsNotNull(productOffers.OfferData.Offers);
            Assert.IsTrue(productOffers.OfferData.Offers.Count > 0);

            await _client.AddItemToBasketAsync(session.SessionId, productOffers.OfferData.Offers.First().Id, 1, "192.168.0.1");

            basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 1);

            await _client.RemoveItemFromBasketAsync(session.SessionId, basket.BasketItems[0].Id);

            basket = await _client.GetBasketAsync(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);
        }
    }
}
