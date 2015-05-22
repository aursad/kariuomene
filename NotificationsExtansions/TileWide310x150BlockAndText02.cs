using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150BlockAndText02 : TileWide310x150Base, ITileWide310x150BlockAndText02
    {
        public TileWide310x150BlockAndText02()
            : base(templateName: "TileWide310x150BlockAndText02", fallbackName: "TileWideBlockAndText02", imageCount: 0, textCount: 6)
        {
        }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
        public INotificationContentText TextBlock { get { return TextFields[1]; } }
        public INotificationContentText TextSubBlock { get { return TextFields[2]; } }
    }
}