using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310BlockAndText01 : TileSquare310x310Base, ITileSquare310x310BlockAndText01
    {
        public TileSquare310x310BlockAndText01()
            : base(templateName: "TileSquare310x310BlockAndText01", fallbackName: null, imageCount: 0, textCount: 9)
        {
        }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody3 { get { return TextFields[3]; } }
        public INotificationContentText TextBody4 { get { return TextFields[4]; } }
        public INotificationContentText TextBody5 { get { return TextFields[5]; } }
        public INotificationContentText TextBody6 { get { return TextFields[6]; } }
        public INotificationContentText TextBlock { get { return TextFields[7]; } }
        public INotificationContentText TextSubBlock { get { return TextFields[8]; } }
    }
}