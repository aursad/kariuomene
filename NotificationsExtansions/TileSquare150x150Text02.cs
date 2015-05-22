using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150Text02 : TileSquare150x150Base, ITileSquare150x150Text02
    {
        public TileSquare150x150Text02()
            : base(templateName: "TileSquare150x150Text02", fallbackName: "TileSquareText02", imageCount: 0, textCount: 2)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}