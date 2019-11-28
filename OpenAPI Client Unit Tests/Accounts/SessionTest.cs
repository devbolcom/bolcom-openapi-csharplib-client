using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class SessionTest
        : ConfiguredTestBase
    {
        [TestMethod]
        public async Task TestGetSession()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);
        }
    }
}
