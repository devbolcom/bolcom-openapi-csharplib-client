namespace Bol.OpenAPI.Client.Request.Catalog
{
    using Bol.OpenAPI.Client.Request.Common;

    public class ProductOffersRequest
    {
        public string Id { get; set; }

        public EnumTypes.OfferType[] Offers { get; set; }
    }
}
