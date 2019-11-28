namespace Bol.OpenAPI.Client.Request.Catalog
{
    using Bol.OpenAPI.Client.Request.Common;

    public class RelatedProductsRequest
    {
        public string Id { get; set; }

        public EnumTypes.DataSetType[] DataSet { get; set; }
    }
}
