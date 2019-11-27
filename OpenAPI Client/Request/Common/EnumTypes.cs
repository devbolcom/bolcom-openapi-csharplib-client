using System.ComponentModel;

namespace Bol.OpenAPI.Request.Common
{
    public static class EnumTypes
    {
        public enum SortingMethod
        {
            [Description("rankasc")]
            RANK_ASC,

            [Description("rankdesc")]
            RANK_DESC,

            [Description("priceasc")]
            PRICE_ASC,

            [Description("pricedesc")]
            PRICE_DESC,

            [Description("titleasc")]
            TITLE_ASC,

            [Description("titledesc")]
            TITLE_DESC,

            [Description("dateasc")]
            DATE_ASC,

            [Description("datedesc")]
            DATE_DESC,

            [Description("ratingasc")]
            RATING_ASC,

            [Description("ratingdesc")]
            RATING_DESC
        }

        public enum DataOutputType
        {
            [Description("products")]
            PRODUCTS,

            [Description("categories")]
            CATEGORIES,

            [Description("refinements")]
            REFINEMENTS
        }

        public enum OfferType
        {
            [Description("cheapest")]
            CHEAPEST,

            [Description("secondhand")]
            SECOND_HAND,

            [Description("plazanew")]
            PLAZA_NEW,

            [Description("bolcom")]
            BOL_COM,

            [Description("all")]
            ALL
        }

        public enum ListType
        {
            [Description("toplist_default")]
            DEFAULT,

            [Description("toplist_overall")]
            OVERALL,

            [Description("toplist_last_week")]
            LAST_WEEK,

            [Description("toplist_last_two_months")]
            LAST_TWO_MONTHS,

            [Description("new")]
            NEW,

            [Description("preorder")]
            PREORDER
        }

        public enum FieldType
        {
            [Description("author")]
            AUTHOR,

            [Description("artist")]
            ARTIST,

            [Description("title")]
            TITLE,

            [Description("brand")]
            BRAND,

            [Description("songtitle")]
            SONG_TITLE,

            [Description("actor")]
            ACTOR,

            [Description("director")]
            DIRECTOR
        }

        public enum DataSetType
        {
            [Description("productfamily")]
            PRODUCT_FAMILY,

            [Description("accessories")]
            ACCESSORIES
        }
    }
}
