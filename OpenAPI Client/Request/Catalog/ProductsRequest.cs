namespace Bol.OpenAPI.Client.Request.Catalog
{
    using Bol.OpenAPI.Client.Request.Common;

    public class ProductsRequest
    {
        public string[] Ids { get; set; }

        public bool? IncludeAttributes { get; set; }

        public EnumTypes.OfferType[] Offers { get; set; }
    }
}
