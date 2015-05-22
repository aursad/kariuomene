using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310Text09 : TileSquare310x310Base, ITileSquare310x310Text09
    {
        public TileSquare310x310Text09()
            : base(templateName: "TileSquare310x310Text09", fallbackName: null, imageCount: 0, textCount: 5)
        {
        }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
        public INotificationContentText TextHeading1 { get { return TextFields[1]; } }
        public INotificationContentText TextHeading2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody1 { get { return TextFields[3]; } }
        public INotificationContentText TextBody2 { get { return TextFields[4]; } }
    }
}