using System.Net;
using System.Text.RegularExpressions;

namespace DdfGuide.Parser
{
    public static class ParserStringExtensions
    {
        public static string Decode(this string encodedString)
        {
            encodedString = RemoveHtmlTags(encodedString);
            encodedString = RemoveHtmlWhitespace(encodedString);
            encodedString = ReplaceNewLineTags(encodedString);
            encodedString = RemoveMultipleWhitespaces(encodedString);
            encodedString = encodedString.Trim();

            return encodedString;
        }

        private static string RemoveMultipleWhitespaces(string encodedString)
        {
            return Regex.Replace(encodedString, @"\s+", " ");
        }

        private static string ReplaceNewLineTags(string encodedString)
        {
            return encodedString.Replace("\n", " ");
        }

        private static string RemoveHtmlWhitespace(string encodedString)
        {
            return Regex.Replace(encodedString, @"\u00A0", " ");
        }

        private static string RemoveHtmlTags(string encodedString)
        {
            return WebUtility.HtmlDecode(encodedString);
        }
    }
}
