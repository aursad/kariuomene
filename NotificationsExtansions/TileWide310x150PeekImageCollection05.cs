using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150PeekImageCollection05 : TileWide310x150Base, ITileWide310x150PeekImageCollection05
    {
        public TileWide310x150PeekImageCollection05()
            : base(templateName: "TileWide310x150PeekImageCollection05", fallbackName: "TileWidePeekImageCollection05", imageCount: 6, textCount: 2)
        {
        }

        public INotificationContentImage ImageMain { get { return Images[0]; } }
        public INotificationContentImage ImageSmallColumn1Row1 { get { return Images[1]; } }
        public INotificationContentImage ImageSmallColumn2Row1 { get { return Images[2]; } }
        public INotificationContentImage ImageSmallColumn1Row2 { get { return Images[3]; } }
        public INotificationContentImage ImageSmallColumn2Row2 { get { return Images[4]; } }
        public INotificationContentImage ImageSecondary { get { return Images[5]; } }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextBodyWrap { get { return TextFields[1]; } }
    }
}