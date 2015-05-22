using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150IconWithBadge : TileSquare150x150Base, ITileSquare150x150IconWithBadge
    {
        public TileSquare150x150IconWithBadge()
            : base(templateName: "TileSquare150x150IconWithBadge", fallbackName: null, imageCount: 1, textCount: 0)
        {
        }

        public INotificationContentImage ImageIcon { get { return Images[0]; } }
    }
}