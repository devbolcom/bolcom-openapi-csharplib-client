using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class ProductOffersTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetProductOffers()
        {
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
        }
    }
}
