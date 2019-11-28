namespace Bol.OpenAPI.Client.Util
{
    using System;
    using System.ComponentModel;

    public static class EnumUtils
    {
        public static string StringValueOf(Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static object EnumValueOf(string value, Type enumType)
        {
            foreach (var name in Enum.GetNames(enumType))
            {
                if (StringValueOf((Enum)Enum.Parse(enumType, name)).Equals(value))
                {
                    return Enum.Parse(enumType, name);
                }
            }

            throw new ArgumentException("The string is not a description or value of the specified enum.");
        }
    }
}
