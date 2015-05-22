using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150PeekImageAndText03 : TileSquare150x150Base, ITileSquare150x150PeekImageAndText03
    {
        public TileSquare150x150PeekImageAndText03()
            : base(templateName: "TileSquare150x150PeekImageAndText03", fallbackName: "TileSquarePeekImageAndText03", imageCount: 1, textCount: 4)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBody1 { get { return TextFields[0]; } }
        public INotificationContentText TextBody2 { get { return TextFields[1]; } }
        public INotificationContentText TextBody3 { get { return TextFields[2]; } }
        public INotificationContentText TextBody4 { get { return TextFields[3]; } }
    }
}