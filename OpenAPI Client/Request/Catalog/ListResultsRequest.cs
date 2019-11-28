namespace Bol.OpenAPI.Client.Request.Catalog
{
    using Bol.OpenAPI.Client.Request.Common;

    public class ListResultsRequest
    {
        public EnumTypes.ListType? Type { get; set; }

        public string CategoryId { get; set; }

        public string[] RefinementIds { get; set; }

        public string ListId { get; set; }

        public bool? IncludeAttributes { get; set; }

        public EnumTypes.DataOutputType[] DataOutputs { get; set; }

        public EnumTypes.OfferType[] Offers { get; set; }

        public EnumTypes.SortingMethod? Sort { get; set; }

        public long? Offset { get; set; }

        public int? Limit { get; set; }
    }
}
