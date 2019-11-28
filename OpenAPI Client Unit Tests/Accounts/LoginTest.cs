using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class LoginTest
        : ConfiguredTestBase
    {
        /// <summary>
        /// Usage of this call is limited and only on request by email to developercenter@bol.com.
        /// https://partnerblog.bol.com/documentatie/open-api/handleiding/api-requests/accounts/post-accountsv4login/
        /// </summary>
        [TestMethod]
        public async Task TestLogin()
        {
            //Login login = client.Login("", null);
            //Assert.IsNotNull(login.Name);
            //Assert.IsNotNull(login.SessionId);
            await Task.CompletedTask;
        }
    }
}
