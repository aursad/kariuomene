using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal interface ISquare150x150TileInternal
    {
        string SerializeBinding(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery);
    }
}