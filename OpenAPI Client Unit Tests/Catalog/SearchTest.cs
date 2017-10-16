using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class SearchTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestSearch()
        {
            SearchResultsRequest searchResultsRequest = new SearchResultsRequest();
            searchResultsRequest.Query = "halo";
            searchResultsRequest.IncludeAttributes = true;
            searchResultsRequest.Offset = 10;
            searchResultsRequest.Limit = 10;
            searchResultsRequest.DataOutputs = new EnumTypes.DataOutputType[] {
                EnumTypes.DataOutputType.PRODUCTS,
                EnumTypes.DataOutputType.CATEGORIES,
                EnumTypes.DataOutputType.REFINEMENTS
            };
            searchResultsRequest.Offers = new EnumTypes.OfferType[] {
                EnumTypes.OfferType.ALL
            };

            SearchResults searchResults = client.Search(searchResultsRequest);
            Assert.IsTrue(searchResults.TotalResultSize > 0);
            Assert.IsNotNull(searchResults.Categories);
            Assert.IsTrue(searchResults.Categories.Count > 0);
            Assert.IsNotNull(searchResults.Products);
            Assert.IsTrue(searchResults.Products.Count > 0);
            Assert.IsNotNull(searchResults.RefinementGroups);
            Assert.IsTrue(searchResults.RefinementGroups.Count > 0);
            Assert.IsTrue(searchResults.Products[0].ParentCategoryPaths.Count > 0);
            Assert.IsTrue(searchResults.Products[0].ParentCategoryPaths[0].ParentCategories.Count > 0);
            Assert.IsFalse(string.IsNullOrEmpty(searchResults.Products[0].ParentCategoryPaths[0].ParentCategories[0].Id));
            Assert.IsFalse(string.IsNullOrEmpty(searchResults.Products[0].ParentCategoryPaths[0].ParentCategories[0].Name));
        }
    }
}
