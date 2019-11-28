namespace Bol.OpenAPI.Request.Catalog
{
    using Bol.OpenAPI.Client.Request.Common;

    public class SellerListRequest
    {
        public string Id { get; set; }

        public bool? IncludeAttributes { get; set; }

        public EnumTypes.SortingMethod? Sort { get; set; }

        public long? Offset { get; set; }

        public int? Limit { get; set; }
    }
}
