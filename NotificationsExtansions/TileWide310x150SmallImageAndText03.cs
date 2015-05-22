using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150SmallImageAndText03 : TileWide310x150Base, ITileWide310x150SmallImageAndText03
    {
        public TileWide310x150SmallImageAndText03()
            : base(templateName: "TileWide310x150SmallImageAndText03", fallbackName: "TileWideSmallImageAndText03", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextBodyWrap { get { return TextFields[0]; } }
    }
}