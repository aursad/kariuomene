using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Text04 : TileWide310x150Base, ITileWide310x150Text04
    {
        public TileWide310x150Text04()
            : base(templateName: "TileWide310x150Text04", fallbackName: "TileWideText04", imageCount: 0, textCount: 1)
        {
        }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}