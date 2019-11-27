using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class ProductRecommendationsTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetProductRecommendation()
        {
            var productRecommendationsRequest = new ProductRecommendationsRequest
            {
                Id = "1004004012288125",
                IncludeAttributes = true,
                Offers = new[] {
                    EnumTypes.OfferType.ALL
            },
                Offset = 0,
                Limit = 10
            };

            var productRecommendations = _client.GetProductRecommendations(productRecommendationsRequest);
            Assert.IsNotNull(productRecommendations.Products);
            Assert.IsTrue(productRecommendations.Products.Count > 0);
        }
    }
}
