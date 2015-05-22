using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150Block : TileSquare150x150Base, ITileSquare150x150Block
    {
        public TileSquare150x150Block()
            : base(templateName: "TileSquare150x150Block", fallbackName: "TileSquareBlock", imageCount: 0, textCount: 2)
        {
        }

        public INotificationContentText TextBlock { get { return TextFields[0]; } }
        public INotificationContentText TextSubBlock { get { return TextFields[1]; } }
    }
}