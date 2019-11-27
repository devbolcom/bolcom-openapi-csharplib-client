using Bol.OpenAPI.Request.Common;

namespace Bol.OpenAPI.Request.Catalog
{
    public class RelatedProductsRequest
    {
        public string Id { get; set; }

        public EnumTypes.DataSetType[] DataSet { get; set; }
    }
}
