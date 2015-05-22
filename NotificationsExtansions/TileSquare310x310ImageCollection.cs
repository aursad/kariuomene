using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310ImageCollection : TileSquare310x310Base, ITileSquare310x310ImageCollection
    {
        public TileSquare310x310ImageCollection()
            : base(templateName: "TileSquare310x310ImageCollection", fallbackName: null, imageCount: 5, textCount: 0)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSmall1 { get { return Images[1]; } }
        public INotificationContentImage ImageSmall2 { get { return Images[2]; } }
        public INotificationContentImage ImageSmall3 { get { return Images[3]; } }
        public INotificationContentImage ImageSmall4 { get { return Images[4]; } }
    }
}