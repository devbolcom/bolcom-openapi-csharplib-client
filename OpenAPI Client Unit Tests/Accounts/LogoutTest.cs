using System.Threading.Tasks;
using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class LogoutTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        /// <summary>
        /// Usage of this call is limited and only on request by email to developercenter@bol.com.
        /// https://partnerblog.bol.com/documentatie/open-api/handleiding/api-requests/accounts/post-accountsv4logout/
        /// </summary>
        [TestMethod]
        public async Task TestLogout()
        {
            //var token = await client.GetRequestAuthTokenAsync(null, null);
            //var login = await client.LoginAsync(token.PrivateToken, null);
            //client.LogoutAsync(login.SessionId);
            await Task.CompletedTask;
        }
    }
}
