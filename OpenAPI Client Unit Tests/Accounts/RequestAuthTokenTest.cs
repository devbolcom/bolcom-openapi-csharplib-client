﻿using System.Threading.Tasks;
using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class RequestAuthTokenTest
        : ConfiguredTestBase
    {
        [TestMethod]
        public async Task TestGetRequestAuthToken()
        {
            var requestAuthToken = await _client.GetRequestAuthTokenAsync("https://m.bol.com/nl/", "https://m.bol.com/nl/error/");
            Assert.IsNotNull(requestAuthToken.Code);
            Assert.IsNotNull(requestAuthToken.PrivateToken);
            Assert.IsNotNull(requestAuthToken.Url);
        }
    }
}
