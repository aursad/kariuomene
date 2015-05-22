using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150ImageAndText01 : TileWide310x150Base, ITileWide310x150ImageAndText01
    {
        public TileWide310x150ImageAndText01()
            : base(templateName: "TileWide310x150ImageAndText01", fallbackName: "TileWideImageAndText01", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextCaptionWrap { get { return TextFields[0]; } }
    }
}