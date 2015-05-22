using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310Text01 : TileSquare310x310Base, ITileSquare310x310Text01
    {
        public TileSquare310x310Text01()
            : base(templateName: "TileSquare310x310Text01", fallbackName: null, imageCount: 0, textCount: 10)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody3 { get { return TextFields[3]; } }
        public INotificationContentText TextBody4 { get { return TextFields[4]; } }
        public INotificationContentText TextBody5 { get { return TextFields[5]; } }
        public INotificationContentText TextBody6 { get { return TextFields[6]; } }
        public INotificationContentText TextBody7 { get { return TextFields[7]; } }
        public INotificationContentText TextBody8 { get { return TextFields[8]; } }
        public INotificationContentText TextBody9 { get { return TextFields[9]; } }
    }
}