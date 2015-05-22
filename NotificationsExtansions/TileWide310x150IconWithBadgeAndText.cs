using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150IconWithBadgeAndText : TileWide310x150Base, ITileWide310x150IconWithBadgeAndText
    {
        public TileWide310x150IconWithBadgeAndText()
            : base(templateName: "TileWide310x150IconWithBadgeAndText", fallbackName: null, imageCount: 1, textCount: 3)
        {
        }

        public INotificationContentImage ImageIcon { get { return Images[0]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBody1 { get { return TextFields[1]; } }
        public INotificationContentText TextBody2 { get { return TextFields[2]; } }
    }
}