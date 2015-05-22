using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310TextList02 : TileSquare310x310Base, ITileSquare310x310TextList02
    {
        public TileSquare310x310TextList02()
            : base(templateName: "TileSquare310x310TextList02", fallbackName: null, imageCount: 0, textCount: 3)
        {
        }

        public INotificationContentText TextWrap1 { get { return TextFields[0]; } }

        public INotificationContentText TextWrap2 { get { return TextFields[1]; } }

        public INotificationContentText TextWrap3 { get { return TextFields[2]; } }
    }
}