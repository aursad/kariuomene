using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150PeekImage03 : TileWide310x150Base, ITileWide310x150PeekImage03
    {
        public TileWide310x150PeekImage03()
            : base(templateName: "TileWide310x150PeekImage03", fallbackName: "TileWidePeekImage03", imageCount: 1, textCount: 1)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}