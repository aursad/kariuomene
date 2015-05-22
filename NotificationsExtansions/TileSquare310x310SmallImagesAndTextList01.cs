using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310SmallImagesAndTextList01 : TileSquare310x310Base, ITileSquare310x310SmallImagesAndTextList01
    {
        public TileSquare310x310SmallImagesAndTextList01()
            : base(templateName: "TileSquare310x310SmallImagesAndTextList01", fallbackName: null, imageCount: 3, textCount: 9)
        {
        }

        public INotificationContentImage Image1 { get { return Images[0]; } }
        public INotificationContentText TextHeading1 { get { return TextFields[0]; } }
        public INotificationContentText TextBodyGroup1Field1 { get { return TextFields[1]; } }
        public INotificationContentText TextBodyGroup1Field2 { get { return TextFields[2]; } }

        public INotificationContentImage Image2 { get { return Images[1]; } }
        public INotificationContentText TextHeading2 { get { return TextFields[3]; } }
        public INotificationContentText TextBodyGroup2Field1 { get { return TextFields[4]; } }
        public INotificationContentText TextBodyGroup2Field2 { get { return TextFields[5]; } }

        public INotificationContentImage Image3 { get { return Images[2]; } }
        public INotificationContentText TextHeading3 { get { return TextFields[6]; } }
        public INotificationContentText TextBodyGroup3Field1 { get { return TextFields[7]; } }
        public INotificationContentText TextBodyGroup3Field2 { get { return TextFields[8]; } }
    }
}