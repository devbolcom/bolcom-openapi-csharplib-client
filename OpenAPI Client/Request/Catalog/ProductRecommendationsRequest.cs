using Bol.OpenAPI.Request.Common;
using System;

namespace Bol.OpenAPI.Request.Catalog
{
    public class ProductRecommendationsRequest
    {
        public string Id { get; set; }

        public bool? IncludeAttributes { get; set; }

        public EnumTypes.OfferType[] Offers { get; set; }

        public long? Offset { get; set; }

        public int? Limit { get; set; }
    }
}
