using System.Threading.Tasks;
using Bol.OpenAPI.Client.Request.Catalog;
using Bol.OpenAPI.Client.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class ProductsTest
        : ConfiguredTestBase
    {
        [TestMethod]
        public async Task TestGetProduct()
        {
            var productsRequest = new ProductsRequest
            {
                Ids = new[] { "1004004012288125" },
                IncludeAttributes = true,
                Offers = new[] {
                    EnumTypes.OfferType.ALL
            }
            };

            var productList = await _client.GetProductsAsync(productsRequest);
            Assert.IsNotNull(productList.Products);
            Assert.IsTrue(productList.Products.Count == 1);
        }

        [TestMethod]
        public async Task TestGetProducts()
        {
            var productsRequest = new ProductsRequest
            {
                Ids = new[] { "1004004012288125", "1004004012257956" },
                IncludeAttributes = true,
                Offers = new[] {
                    EnumTypes.OfferType.ALL
            }
            };

            var productList = await _client.GetProductsAsync(productsRequest);
            Assert.IsNotNull(productList.Products);
            Assert.IsTrue(productList.Products.Count == 2);
        }
    }
}
