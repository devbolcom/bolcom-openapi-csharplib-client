using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class SearchTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestSearch()
        {
            var searchResultsRequest = new SearchResultsRequest
            {
                Query = "halo",
                IncludeAttributes = true,
                Offset = 10,
                Limit = 10,
                DataOutputs = new[] {
                    EnumTypes.DataOutputType.PRODUCTS,
                    EnumTypes.DataOutputType.CATEGORIES,
                    EnumTypes.DataOutputType.REFINEMENTS
                },
                Offers = new[] {
                    EnumTypes.OfferType.ALL
                }
            };

            var searchResults = _client.Search(searchResultsRequest);
            Assert.IsTrue(searchResults.TotalResultSize > 0);
            Assert.IsNotNull(searchResults.Categories);
            Assert.IsTrue(searchResults.Categories.Count > 0);
            Assert.IsNotNull(searchResults.Products);
            Assert.IsTrue(searchResults.Products.Count > 0);
            Assert.IsNotNull(searchResults.RefinementGroups);
            Assert.IsTrue(searchResults.RefinementGroups.Count > 0);     
        }
    }
}
