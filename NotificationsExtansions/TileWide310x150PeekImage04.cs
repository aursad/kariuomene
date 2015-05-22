using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150PeekImage04 : TileWide310x150Base, ITileWide310x150PeekImage04
    {
        public TileWide310x150PeekImage04()
            : base(templateName: "TileWide310x150PeekImage04", fallbackName: "TileWidePeekImage04", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}