using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310ImageAndText01 : TileSquare310x310Base, ITileSquare310x310ImageAndText01
    {
        public TileSquare310x310ImageAndText01()
            : base(templateName: "TileSquare310x310ImageAndText01", fallbackName: null, imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextCaptionWrap { get { return TextFields[0]; } }
    }
}