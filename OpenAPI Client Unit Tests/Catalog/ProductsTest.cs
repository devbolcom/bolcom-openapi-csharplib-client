using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class ProductsTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetProduct()
        {
            var productsRequest = new ProductsRequest
            {
                Ids = new[] { "1004004012288125" },
                IncludeAttributes = true,
                Offers = new[] {
                    EnumTypes.OfferType.ALL
            }
            };

            var productList = _client.GetProducts(productsRequest);
            Assert.IsNotNull(productList.Products);
            Assert.IsTrue(productList.Products.Count == 1);
        }

        [TestMethod]
        public void TestGetProducts()
        {
            var productsRequest = new ProductsRequest
            {
                Ids = new[] { "1004004012288125", "1004004012257956" },
                IncludeAttributes = true,
                Offers = new[] {
                    EnumTypes.OfferType.ALL
            }
            };

            var productList = _client.GetProducts(productsRequest);
            Assert.IsNotNull(productList.Products);
            Assert.IsTrue(productList.Products.Count == 2);
        }
    }
}
