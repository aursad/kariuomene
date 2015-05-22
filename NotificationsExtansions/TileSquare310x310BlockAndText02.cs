using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310BlockAndText02 : TileSquare310x310Base, ITileSquare310x310BlockAndText02
    {
        public TileSquare310x310BlockAndText02()
            : base(templateName: "TileSquare310x310BlockAndText02", fallbackName: null, imageCount: 1, textCount: 7)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBlock { get { return TextFields[0]; } }
        public INotificationContentText TextHeading1 { get { return TextFields[1]; } }
        public INotificationContentText TextHeading2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody1 { get { return TextFields[3]; } }
        public INotificationContentText TextBody2 { get { return TextFields[4]; } }
        public INotificationContentText TextBody3 { get { return TextFields[5]; } }
        public INotificationContentText TextBody4 { get { return TextFields[6]; } }
    }
}