using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal interface IWide310x150TileInternal
    {
        string SerializeBindings(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery);
    }
}