namespace Bol.OpenAPI.Client.Util
{
    using System.Text;
    using Bol.OpenAPI.Client.Request.Common;

    internal static class FormatterUtils
    {
        public static string CombineCategoryAndRefinementIds(string categoryId, string[] refinementIds)
        {
            var sb = new StringBuilder();
            if (categoryId != null)
            {
                sb.Append(categoryId);
            }
            if (refinementIds != null)
            {
                sb.Append(',');

                for (var i = 0; i < refinementIds.Length; i++)
                {
                    sb.Append(refinementIds[i]);

                    if (i + 1 < refinementIds.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }

        public static string FormatIds(string[] ids)
        {
            var sb = new StringBuilder();
            if (ids != null)
            {
                for (var i = 0; i < ids.Length; i++)
                {
                    sb.Append(ids[i]);

                    if (i + 1 < ids.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }

        public static string FormatDataOutput(EnumTypes.DataOutputType[] dataOutputs)
        {
            var sb = new StringBuilder();
            if (dataOutputs != null)
            {
                for (var i = 0; i < dataOutputs.Length; i++)
                {
                    sb.Append(EnumUtils.StringValueOf(dataOutputs[i]));

                    if (i + 1 < dataOutputs.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }

        public static string FormatOffer(EnumTypes.OfferType[] offers)
        {
            var sb = new StringBuilder();
            if (offers != null)
            {

                for (var i = 0; i < offers.Length; i++)
                {
                    sb.Append(EnumUtils.StringValueOf(offers[i]));

                    if (i + 1 < offers.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }

        public static string FormatDataSet(EnumTypes.DataSetType[] dataSet)
        {
            var sb = new StringBuilder();
            if (dataSet != null)
            {

                for (var i = 0; i < dataSet.Length; i++)
                {
                    sb.Append(EnumUtils.StringValueOf(dataSet[i]));

                    if (i + 1 < dataSet.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }
    }
}
