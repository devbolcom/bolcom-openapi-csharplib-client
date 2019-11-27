using Bol.OpenAPI.Request.Common;

namespace Bol.OpenAPI.Request.Catalog
{
    public class SearchResultsRequest
    {
        public string Query { get; set; }

        public string ProductIds { get; set; }

        public string CategoryId { get; set; }

        public string[] RefinementIds { get; set; }

        public string ListId { get; set; }

        public EnumTypes.FieldType? Field { get; set; }

        public bool? IncludeAttributes { get; set; }

        public EnumTypes.DataOutputType[] DataOutputs { get; set; }

        public EnumTypes.OfferType[] Offers { get; set; }

        public EnumTypes.SortingMethod? Sort { get; set; }

        public long? Offset { get; set; }

        public int? Limit { get; set; }
    }
}
