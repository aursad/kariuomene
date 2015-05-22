using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310ImageAndTextOverlay03 : TileSquare310x310Base, ITileSquare310x310ImageAndTextOverlay03
    {
        public TileSquare310x310ImageAndTextOverlay03()
            : base(templateName: "TileSquare310x310ImageAndTextOverlay03", fallbackName: null, imageCount: 1, textCount: 4)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
        public INotificationContentText TextBody3 { get { return TextFields[3]; } }
    }
}