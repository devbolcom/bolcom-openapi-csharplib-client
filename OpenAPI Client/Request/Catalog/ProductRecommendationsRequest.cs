namespace Bol.OpenAPI.Client.Request.Catalog
{
    using Bol.OpenAPI.Client.Request.Common;

    public class ProductRecommendationsRequest
    {
        public string Id { get; set; }

        public bool? IncludeAttributes { get; set; }

        public EnumTypes.OfferType[] Offers { get; set; }

        public long? Offset { get; set; }

        public int? Limit { get; set; }
    }
}
