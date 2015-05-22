using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150SmallImageAndText01 : TileWide310x150Base, ITileWide310x150SmallImageAndText01
    {
        public TileWide310x150SmallImageAndText01()
            : base(templateName: "TileWide310x150SmallImageAndText01", fallbackName: "TileWideSmallImageAndText01", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}