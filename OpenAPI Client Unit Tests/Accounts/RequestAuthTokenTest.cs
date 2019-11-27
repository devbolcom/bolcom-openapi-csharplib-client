using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class RequestAuthTokenTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetRequestAuthToken()
        {
            var requestAuthToken = _client.GetRequestAuthToken("https://m.bol.com/nl/", "https://m.bol.com/nl/error/");
            Assert.IsNotNull(requestAuthToken.Code);
            Assert.IsNotNull(requestAuthToken.PrivateToken);
            Assert.IsNotNull(requestAuthToken.Url);
        }
    }
}
