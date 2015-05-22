using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150SmallImageAndText05 : TileWide310x150Base, ITileWide310x150SmallImageAndText05
    {
        public TileWide310x150SmallImageAndText05()
            : base(templateName: "TileWide310x150SmallImageAndText05", fallbackName: "TileWideSmallImageAndText05", imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}