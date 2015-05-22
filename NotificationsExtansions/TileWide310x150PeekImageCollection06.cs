using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150PeekImageCollection06 : TileWide310x150Base, ITileWide310x150PeekImageCollection06
    {
        public TileWide310x150PeekImageCollection06()
            : base(templateName: "TileWide310x150PeekImageCollection06", fallbackName: "TileWidePeekImageCollection06", imageCount: 6, textCount: 1)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSmallColumn1Row1 { get { return Images[1]; } }
        public INotificationContentImage ImageSmallColumn2Row1 { get { return Images[2]; } }
        public INotificationContentImage ImageSmallColumn1Row2 { get { return Images[3]; } }
        public INotificationContentImage ImageSmallColumn2Row2 { get { return Images[4]; } }
        public INotificationContentImage ImageSecondary { get { return Images[5]; } }

        public INotificationContentText TextHeadingWrap { get { return TextFields[0]; } }
    }
}