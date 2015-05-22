using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150PeekImageAndText02 : TileSquare150x150Base, ITileSquare150x150PeekImageAndText02
    {
        public TileSquare150x150PeekImageAndText02()
            : base(templateName: "TileSquare150x150PeekImageAndText02", fallbackName: "TileSquarePeekImageAndText02", imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}