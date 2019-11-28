using System.Threading.Tasks;
using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class PingTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public async Task TestPing()
        {
            var pong = await _client.PingAsync();
            Assert.IsNotNull(pong.Message);
        }
    }
}
