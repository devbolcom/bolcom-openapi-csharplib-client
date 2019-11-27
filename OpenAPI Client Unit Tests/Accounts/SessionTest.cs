using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class SessionTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetSession()
        {
            var session = _client.GetSession();
            Assert.IsNotNull(session.SessionId);
        }
    }
}
