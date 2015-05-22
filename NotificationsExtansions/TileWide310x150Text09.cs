using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Text09 : TileWide310x150Base, ITileWide310x150Text09
    {
        public TileWide310x150Text09()
            : base(templateName: "TileWide310x150Text09", fallbackName: "TileWideText09", imageCount: 0, textCount: 2)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}