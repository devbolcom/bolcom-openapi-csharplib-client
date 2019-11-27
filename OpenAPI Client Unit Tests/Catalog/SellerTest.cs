using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class SellerTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetSellerList()
        {
            var sellerListRequest = new SellerListRequest
            {
                Id = "1023995",
                IncludeAttributes = true,
                Offset = 0,
                Limit = 10,
                Sort = EnumTypes.SortingMethod.DATE_DESC
            };

            var sellerList = _client.GetSellerList(sellerListRequest);
            Assert.IsNotNull(sellerList.Products);
            Assert.IsTrue(sellerList.Products.Count > 0);
        }
    }
}
