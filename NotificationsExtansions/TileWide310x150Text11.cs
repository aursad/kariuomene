using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Text11 : TileWide310x150Base, ITileWide310x150Text11
    {
        public TileWide310x150Text11()
            : base(templateName: "TileWide310x150Text11", fallbackName: "TileWideText11", imageCount: 0, textCount: 10)
        {
        }

        public INotificationContentText TextPrefixColumn1Row1 { get { return TextFields[0]; } }
        public INotificationContentText TextColumn2Row1 { get { return TextFields[1]; } }
        public INotificationContentText TextPrefixColumn1Row2 { get { return TextFields[2]; } }
        public INotificationContentText TextColumn2Row2 { get { return TextFields[3]; } }
        public INotificationContentText TextPrefixColumn1Row3 { get { return TextFields[4]; } }
        public INotificationContentText TextColumn2Row3 { get { return TextFields[5]; } }
        public INotificationContentText TextPrefixColumn1Row4 { get { return TextFields[6]; } }
        public INotificationContentText TextColumn2Row4 { get { return TextFields[7]; } }
        public INotificationContentText TextPrefixColumn1Row5 { get { return TextFields[8]; } }
        public INotificationContentText TextColumn2Row5 { get { return TextFields[9]; } }
    }
}