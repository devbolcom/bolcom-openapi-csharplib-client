using Bol.OpenAPI.Request.Common;

namespace Bol.OpenAPI.Request.Catalog
{
    public class SellerListRequest
    {
        public string Id { get; set; }

        public bool? IncludeAttributes { get; set; }

        public EnumTypes.SortingMethod? Sort { get; set; }

        public long? Offset { get; set; }

        public int? Limit { get; set; }
    }
}
