using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150PeekImage02 : TileWide310x150Base, ITileWide310x150PeekImage02
    {
        public TileWide310x150PeekImage02()
            : base(templateName: "TileWide310x150PeekImage02", fallbackName: "TileWidePeekImage02", imageCount: 1, textCount: 5)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody3 { get { return TextFields[3]; } }
        public INotificationContentText TextBody4 { get { return TextFields[4]; } }
    }
}