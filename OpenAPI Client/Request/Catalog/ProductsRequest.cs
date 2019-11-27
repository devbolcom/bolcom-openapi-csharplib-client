using Bol.OpenAPI.Request.Common;
using System;

namespace Bol.OpenAPI.Request.Catalog
{
    public class ProductsRequest
    {
        public string[] Ids { get; set; }

        public bool? IncludeAttributes { get; set; }

        public EnumTypes.OfferType[] Offers { get; set; }
    }
}
