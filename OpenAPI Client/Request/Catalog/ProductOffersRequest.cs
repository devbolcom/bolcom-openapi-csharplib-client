using Bol.OpenAPI.Request.Common;

namespace Bol.OpenAPI.Request.Catalog
{
    public class ProductOffersRequest
    {
        public string Id { get; set; }

        public EnumTypes.OfferType[] Offers { get; set; }
    }
}
