namespace NotificationsExtansions
{
    internal static class Util
    {
        public const int NOTIFICATION_CONTENT_VERSION = 1;

        public static string HttpEncode(string value)
        {
            return value.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("'", "&apos;");
        }
    }
}