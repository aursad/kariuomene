using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310TextList03 : TileSquare310x310Base, ITileSquare310x310TextList03
    {
        public TileSquare310x310TextList03()
            : base(templateName: "TileSquare310x310TextList03", fallbackName: null, imageCount: 0, textCount: 6)
        {
        }

        public INotificationContentText TextHeading1 { get { return TextFields[0]; } }
        public INotificationContentText TextWrap1 { get { return TextFields[1]; } }

        public INotificationContentText TextHeading2 { get { return TextFields[2]; } }
        public INotificationContentText TextWrap2 { get { return TextFields[3]; } }

        public INotificationContentText TextHeading3 { get { return TextFields[4]; } }
        public INotificationContentText TextWrap3 { get { return TextFields[5]; } }
    }
}