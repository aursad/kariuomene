using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150Text04 : TileSquare150x150Base, ITileSquare150x150Text04
    {
        public TileSquare150x150Text04()
            : base(templateName: "TileSquare150x150Text04", fallbackName: "TileSquareText04", imageCount: 0, textCount: 1)
        {
        }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}