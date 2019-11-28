using System.Threading.Tasks;
using Bol.OpenAPI.Client.Request.Catalog;
using Bol.OpenAPI.Client.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class ProductOffersTest
        : ConfiguredTestBase
    {
        [TestMethod]
        public async Task TestGetProductOffers()
        {
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
        }
    }
}
