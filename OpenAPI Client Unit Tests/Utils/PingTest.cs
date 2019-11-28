using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class PingTest
        : ConfiguredTestBase
    {
        [TestMethod]
        public async Task TestPing()
        {
            var pong = await _client.PingAsync();
            Assert.IsNotNull(pong.Message);
        }
    }
}
