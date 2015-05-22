using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Text03 : TileWide310x150Base, ITileWide310x150Text03
    {
        public TileWide310x150Text03()
            : base(templateName: "TileWide310x150Text03", fallbackName: "TileWideText03", imageCount: 0, textCount: 1)
        {
        }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}