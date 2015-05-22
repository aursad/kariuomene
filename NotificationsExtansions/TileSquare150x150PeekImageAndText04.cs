using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150PeekImageAndText04 : TileSquare150x150Base, ITileSquare150x150PeekImageAndText04
    {
        public TileSquare150x150PeekImageAndText04()
            : base(templateName: "TileSquare150x150PeekImageAndText04", fallbackName: "TileSquarePeekImageAndText04", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}