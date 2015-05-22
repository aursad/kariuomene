using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Text05 : TileWide310x150Base, ITileWide310x150Text05
    {
        public TileWide310x150Text05()
            : base(templateName: "TileWide310x150Text05", fallbackName: "TileWideText05", imageCount: 0, textCount: 5)
        {
        }

        public INotificationContentText TextBody1 { get { return TextFields[0]; } }
        public INotificationContentText TextBody2 { get { return TextFields[1]; } }
        public INotificationContentText TextBody3 { get { return TextFields[2]; } }
        public INotificationContentText TextBody4 { get { return TextFields[3]; } }
        public INotificationContentText TextBody5 { get { return TextFields[4]; } }
    }
}