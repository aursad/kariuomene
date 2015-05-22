using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310ImageAndText02 : TileSquare310x310Base, ITileSquare310x310ImageAndText02
    {
        public TileSquare310x310ImageAndText02()
            : base(templateName: "TileSquare310x310ImageAndText02", fallbackName: null, imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextCaption1 { get { return TextFields[0]; } }
        public INotificationContentText TextCaption2 { get { return TextFields[1]; } }
    }
}