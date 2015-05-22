using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150ImageAndText02 : TileWide310x150Base, ITileWide310x150ImageAndText02
    {
        public TileWide310x150ImageAndText02()
            : base(templateName: "TileWide310x150ImageAndText02", fallbackName: "TileWideImageAndText02", imageCount: 1, textCount: 2)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextCaption1 { get { return TextFields[0]; } }
        public INotificationContentText TextCaption2 { get { return TextFields[1]; } }
    }
}