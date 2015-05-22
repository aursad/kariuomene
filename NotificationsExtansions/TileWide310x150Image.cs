using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Image : TileWide310x150Base, ITileWide310x150Image
    {
        public TileWide310x150Image()
            : base(templateName: "TileWide310x150Image", fallbackName: "TileWideImage", imageCount: 1, textCount: 0)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }
    }
}