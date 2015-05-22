using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310ImageCollectionAndText02 : TileSquare310x310Base, ITileSquare310x310ImageCollectionAndText02
    {
        public TileSquare310x310ImageCollectionAndText02()
            : base(templateName: "TileSquare310x310ImageCollectionAndText02", fallbackName: null, imageCount: 5, textCount: 2)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSmall1 { get { return Images[1]; } }
        public INotificationContentImage ImageSmall2 { get { return Images[2]; } }
        public INotificationContentImage ImageSmall3 { get { return Images[3]; } }
        public INotificationContentImage ImageSmall4 { get { return Images[4]; } }

        public INotificationContentText TextCaption1 { get { return TextFields[0]; } }
        public INotificationContentText TextCaption2 { get { return TextFields[1]; } }
    }
}