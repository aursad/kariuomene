using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150PeekImageAndText01 : TileWide310x150Base, ITileWide310x150PeekImageAndText01
    {
        public TileWide310x150PeekImageAndText01()
            : base(templateName: "TileWide310x150PeekImageAndText01", fallbackName: "TileWidePeekImageAndText01", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}