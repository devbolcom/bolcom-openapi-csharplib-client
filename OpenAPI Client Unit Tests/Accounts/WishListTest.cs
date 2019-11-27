using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class WishListTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetWishList()
        {
            var session = _client.GetSession();
            Assert.IsNotNull(session.SessionId);

            var wishList = _client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);
        }

        [TestMethod]
        public void TestAddItemToWishList()
        {
            var session = _client.GetSession();
            Assert.IsNotNull(session.SessionId);

            var wishList = _client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

            _client.AddItemToWishList(session.SessionId, "1004004012288125");

            wishList = _client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 1);
        }

        [TestMethod]
        public void TestRemoveItemFromWishList()
        {
            var session = _client.GetSession();
            Assert.IsNotNull(session.SessionId);

            var wishList = _client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

            _client.AddItemToWishList(session.SessionId, "1004004012288125");

            wishList = _client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 1);

            _client.RemoveItemFromWishList(session.SessionId, wishList.WishListItems[0].Id);

            wishList = _client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

        }
    }
}
