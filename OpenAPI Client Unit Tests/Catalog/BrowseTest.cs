using System.Threading.Tasks;
using Bol.OpenAPI.Client.Request.Catalog;
using Bol.OpenAPI.Client.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class BrowseTest
        : ConfiguredTestBase
    {
        [TestMethod]
        public async Task TestBrowse()
        {
            var listResultsRequest = new ListResultsRequest
            {
                Type = EnumTypes.ListType.DEFAULT,
                CategoryId = "3135",
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

            var listResults = await _client.BrowseAsync(listResultsRequest);
            Assert.IsTrue(listResults.TotalResultSize > 0);
            Assert.IsNotNull(listResults.Categories);
            Assert.IsTrue(listResults.Categories.Count > 0);
            Assert.IsNotNull(listResults.Products);
            Assert.IsTrue(listResults.Products.Count > 0);
            Assert.IsNotNull(listResults.RefinementGroups);
            Assert.IsTrue(listResults.RefinementGroups.Count > 0);     
        }
    }
}
