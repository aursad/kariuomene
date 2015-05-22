using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310ImageCollectionAndText01 : TileSquare310x310Base, ITileSquare310x310ImageCollectionAndText01
    {
        public TileSquare310x310ImageCollectionAndText01()
            : base(templateName: "TileSquare310x310ImageCollectionAndText01", fallbackName: null, imageCount: 5, textCount: 1)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSmall1 { get { return Images[1]; } }
        public INotificationContentImage ImageSmall2 { get { return Images[2]; } }
        public INotificationContentImage ImageSmall3 { get { return Images[3]; } }
        public INotificationContentImage ImageSmall4 { get { return Images[4]; } }

        public INotificationContentText TextCaptionWrap { get { return TextFields[0]; } }
    }
}