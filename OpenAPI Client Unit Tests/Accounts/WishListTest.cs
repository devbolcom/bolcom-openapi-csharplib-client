using System.Threading.Tasks;
using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class WishListTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public async Task TestGetWishList()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);

            var wishList = await _client.GetWishListAsync(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);
        }

        [TestMethod]
        public async Task TestAddItemToWishList()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);

            var wishList = await _client.GetWishListAsync(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

            await _client.AddItemToWishListAsync(session.SessionId, "1004004012288125");

            wishList = await _client.GetWishListAsync(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 1);
        }

        [TestMethod]
        public async Task TestRemoveItemFromWishList()
        {
            var session = await _client.GetSessionAsync();
            Assert.IsNotNull(session.SessionId);

            var wishList = await _client.GetWishListAsync(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

            await _client.AddItemToWishListAsync(session.SessionId, "1004004012288125");

            wishList = await _client.GetWishListAsync(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 1);

            await _client.RemoveItemFromWishListAsync(session.SessionId, wishList.WishListItems[0].Id);

            wishList = await _client.GetWishListAsync(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

        }
    }
}
