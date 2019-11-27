using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class RelatedProductsTest
    {
        private readonly OpenApiClient _client = new OpenApiClient(Constants.ApiKey);

        [TestMethod]
        public void TestGetProductFamilies()
        {
            var relatedProductsRequest = new RelatedProductsRequest
            {
                Id = "9000000012049645",
                DataSet = new[] {
                    EnumTypes.DataSetType.PRODUCT_FAMILY
            }
            };

            var relatedProducts = _client.GetRelatedProducts(relatedProductsRequest);
            Assert.IsNotNull(relatedProducts.ProductFamilies);
            Assert.IsTrue(relatedProducts.ProductFamilies.Count > 0);
        }

        /// <summary>
        /// This method returns API error
        /// </summary>
        [TestMethod]
        public void TestGetAccessories()
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
        }
    }
}
