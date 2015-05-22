using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310ImageAndTextOverlay01 : TileSquare310x310Base, ITileSquare310x310ImageAndTextOverlay01
    {
        public TileSquare310x310ImageAndTextOverlay01()
            : base(templateName: "TileSquare310x310ImageAndTextOverlay01", fallbackName: null, imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}