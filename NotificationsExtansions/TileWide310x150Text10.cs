using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Text10 : TileWide310x150Base, ITileWide310x150Text10
    {
        public TileWide310x150Text10()
            : base(templateName: "TileWide310x150Text10", fallbackName: "TileWideText10", imageCount: 0, textCount: 9)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }
        public INotificationContentText TextPrefixColumn1Row1 { get { return TextFields[1]; } }
        public INotificationContentText TextColumn2Row1 { get { return TextFields[2]; } }
        public INotificationContentText TextPrefixColumn1Row2 { get { return TextFields[3]; } }
        public INotificationContentText TextColumn2Row2 { get { return TextFields[4]; } }
        public INotificationContentText TextPrefixColumn1Row3 { get { return TextFields[5]; } }
        public INotificationContentText TextColumn2Row3 { get { return TextFields[6]; } }
        public INotificationContentText TextPrefixColumn1Row4 { get { return TextFields[7]; } }
        public INotificationContentText TextColumn2Row4 { get { return TextFields[8]; } }
    }
}