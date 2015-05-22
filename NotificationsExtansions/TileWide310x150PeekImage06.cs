using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150PeekImage06 : TileWide310x150Base, ITileWide310x150PeekImage06
    {
        public TileWide310x150PeekImage06()
            : base(templateName: "TileWide310x150PeekImage06", fallbackName: "TileWidePeekImage06", imageCount: 2, textCount: 1)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSecondary { get { return Images[1]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}