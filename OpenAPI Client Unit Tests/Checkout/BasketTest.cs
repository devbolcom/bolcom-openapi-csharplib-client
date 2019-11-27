using System.Linq;
using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class BasketTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetBasket()
        {
            var session = _client.GetSession();
            Assert.IsNotNull(session.SessionId);

            var basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);
        }

        [TestMethod]
        public void TestAddItemToBasket()
        {
            var session = _client.GetSession();
            Assert.IsNotNull(session.SessionId);

            var basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);

            var productOffersRequest = new ProductOffersRequest
            {
                Id = "1004004012288125",
                Offers = new[] {
                    EnumTypes.OfferType.ALL
                }
            };

            var productOffers = _client.GetProductOffers(productOffersRequest);
            Assert.IsNotNull(productOffers.OfferData);
            Assert.IsNotNull(productOffers.OfferData.Offers);
            Assert.IsTrue(productOffers.OfferData.Offers.Count > 0);

            _client.AddItemToBasket(session.SessionId, productOffers.OfferData.Offers.First().Id, 1, "192.168.0.1");

            basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 1);
        }

        [TestMethod]
        public void TestChangeItemQuantityInBasket()
        {
            var session = _client.GetSession();
            Assert.IsNotNull(session.SessionId);

            var basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);

            var productOffersRequest = new ProductOffersRequest
            {
                Id = "1004004012288125",
                Offers = new[] {
                    EnumTypes.OfferType.ALL
                }
            };

            var productOffers = _client.GetProductOffers(productOffersRequest);
            Assert.IsNotNull(productOffers.OfferData);
            Assert.IsNotNull(productOffers.OfferData.Offers);
            Assert.IsTrue(productOffers.OfferData.Offers.Count > 0);

            _client.AddItemToBasket(session.SessionId, productOffers.OfferData.Offers.First().Id, 1, "192.168.0.1");

            basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 1);
            Assert.IsTrue(basket.BasketItems[0].Quantity == 1);

            _client.ChangeItemQuantityInBasket(session.SessionId, basket.BasketItems[0].Id, 2);

            basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 1);
            Assert.IsTrue(basket.BasketItems[0].Quantity == 2);
        }

        [TestMethod]
        public void TestRemoveItemFromBasket()
        {
            var session = _client.GetSession();
            Assert.IsNotNull(session.SessionId);

            var basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);

            var productOffersRequest = new ProductOffersRequest
            {
                Id = "1004004012288125",
                Offers = new[] {
                    EnumTypes.OfferType.ALL
                }
            };

            var productOffers = _client.GetProductOffers(productOffersRequest);
            Assert.IsNotNull(productOffers.OfferData);
            Assert.IsNotNull(productOffers.OfferData.Offers);
            Assert.IsTrue(productOffers.OfferData.Offers.Count > 0);

            _client.AddItemToBasket(session.SessionId, productOffers.OfferData.Offers.First().Id, 1, "192.168.0.1");

            basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 1);

            _client.RemoveItemFromBasket(session.SessionId, basket.BasketItems[0].Id);

            basket = _client.GetBasket(session.SessionId);
            Assert.IsTrue(basket.BasketItems.Count == 0);
        }
    }
}
