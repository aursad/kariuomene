using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310SmallImageAndText01 : TileSquare310x310Base, ITileSquare310x310SmallImageAndText01
    {
        public TileSquare310x310SmallImageAndText01()
            : base(templateName: "TileSquare310x310SmallImageAndText01", fallbackName: null, imageCount: 1, textCount: 3)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }
        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
        public INotificationContentText TextBody { get { return TextFields[2]; } }
    }
}