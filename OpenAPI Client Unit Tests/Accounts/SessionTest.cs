using System.Threading.Tasks;
using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class SessionTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public async Task TestGetSession()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);
        }
    }
}
