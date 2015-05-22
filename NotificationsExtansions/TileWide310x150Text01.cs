using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Text01 : TileWide310x150Base, ITileWide310x150Text01
    {
        public TileWide310x150Text01()
            : base(templateName: "TileWide310x150Text01", fallbackName: "TileWideText01", imageCount: 0, textCount: 5)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody3 { get { return TextFields[3]; } }
        public INotificationContentText TextBody4 { get { return TextFields[4]; } }
    }
}