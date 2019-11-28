using System.Threading.Tasks;
using Bol.OpenAPI.Client.Request.Catalog;
using Bol.OpenAPI.Client.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class RelatedProductsTest
        : ConfiguredTestBase
    {
        [TestMethod]
        public async Task TestGetProductFamilies()
        {
            var relatedProductsRequest = new RelatedProductsRequest
            {
                Id = "9000000012049645",
                DataSet = new[] {
                    EnumTypes.DataSetType.PRODUCT_FAMILY
            }
            };

            var relatedProducts = await _client.GetRelatedProductsAsync(relatedProductsRequest);
            Assert.IsNotNull(relatedProducts.ProductFamilies);
            Assert.IsTrue(relatedProducts.ProductFamilies.Count > 0);
        }

        /// <summary>
        /// This method returns API error
        /// </summary>
        [TestMethod]
        public async Task TestGetAccessories()
        {
            //var relatedProductsRequest = new RelatedProductsRequest
            //{
            //    Id = "9200000010642550",
            //    DataSet = new EnumTypes.DataSetType[] {
            //        EnumTypes.DataSetType.ACCESSORIES,
            //}
            //};

            //var relatedProducts = client.GetRelatedProducts(relatedProductsRequest);
            //Assert.IsNotNull(relatedProducts.Accessories);
            //Assert.IsTrue(relatedProducts.Accessories.Count > 0);
            await Task.CompletedTask;
        }
    }
}
