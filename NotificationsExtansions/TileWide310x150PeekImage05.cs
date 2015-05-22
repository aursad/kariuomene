using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150PeekImage05 : TileWide310x150Base, ITileWide310x150PeekImage05
    {
        public TileWide310x150PeekImage05()
            : base(templateName: "TileWide310x150PeekImage05", fallbackName: "TileWidePeekImage05", imageCount: 2, textCount: 2)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSecondary { get { return Images[1]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}