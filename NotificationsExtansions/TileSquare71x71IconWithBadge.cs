using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare71x71IconWithBadge : TileSquare71x71Base, ITileSquare71x71IconWithBadge
    {
        public TileSquare71x71IconWithBadge()
            : base(templateName: "TileSquare71x71IconWithBadge", fallbackName: null, imageCount: 1, textCount: 0)
        {
        }

        public INotificationContentImage ImageIcon { get { return Images[0]; } }
    }
}