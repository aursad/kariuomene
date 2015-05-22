using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310ImageAndTextOverlay02 : TileSquare310x310Base, ITileSquare310x310ImageAndTextOverlay02
    {
        public TileSquare310x310ImageAndTextOverlay02()
            : base(templateName: "TileSquare310x310ImageAndTextOverlay02", fallbackName: null, imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}