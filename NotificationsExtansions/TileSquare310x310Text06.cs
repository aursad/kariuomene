using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310Text06 : TileSquare310x310Base, ITileSquare310x310Text06
    {
        public TileSquare310x310Text06()
            : base(templateName: "TileSquare310x310Text06", fallbackName: null, imageCount: 0, textCount: 22)
        {
        }

        public INotificationContentText TextColumn1Row1 { get { return TextFields[0]; } }
        public INotificationContentText TextColumn2Row1 { get { return TextFields[1]; } }
        public INotificationContentText TextColumn1Row2 { get { return TextFields[2]; } }
        public INotificationContentText TextColumn2Row2 { get { return TextFields[3]; } }
        public INotificationContentText TextColumn1Row3 { get { return TextFields[4]; } }
        public INotificationContentText TextColumn2Row3 { get { return TextFields[5]; } }
        public INotificationContentText TextColumn1Row4 { get { return TextFields[6]; } }
        public INotificationContentText TextColumn2Row4 { get { return TextFields[7]; } }
        public INotificationContentText TextColumn1Row5 { get { return TextFields[8]; } }
        public INotificationContentText TextColumn2Row5 { get { return TextFields[9]; } }
        public INotificationContentText TextColumn1Row6 { get { return TextFields[10]; } }
        public INotificationContentText TextColumn2Row6 { get { return TextFields[11]; } }
        public INotificationContentText TextColumn1Row7 { get { return TextFields[12]; } }
        public INotificationContentText TextColumn2Row7 { get { return TextFields[13]; } }
        public INotificationContentText TextColumn1Row8 { get { return TextFields[14]; } }
        public INotificationContentText TextColumn2Row8 { get { return TextFields[15]; } }
        public INotificationContentText TextColumn1Row9 { get { return TextFields[16]; } }
        public INotificationContentText TextColumn2Row9 { get { return TextFields[17]; } }
        public INotificationContentText TextColumn1Row10 { get { return TextFields[18]; } }
        public INotificationContentText TextColumn2Row10 { get { return TextFields[19]; } }
        public INotificationContentText TextColumn1Row11 { get { return TextFields[20]; } }
        public INotificationContentText TextColumn2Row11 { get { return TextFields[21]; } }
    }
}