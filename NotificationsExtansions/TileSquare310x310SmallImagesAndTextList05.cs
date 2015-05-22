using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310SmallImagesAndTextList05 : TileSquare310x310Base, ITileSquare310x310SmallImagesAndTextList05
    {
        public TileSquare310x310SmallImagesAndTextList05()
            : base(templateName: "TileSquare310x310SmallImagesAndTextList05", fallbackName: null, imageCount: 3, textCount: 7)
        {
        }

        public INotificationContentText TextHeading { get { return TextFields[0]; } }

        public INotificationContentImage Image1 { get { return Images[0]; } }
        public INotificationContentText TextGroup1Field1 { get { return TextFields[1]; } }
        public INotificationContentText TextGroup1Field2 { get { return TextFields[2]; } }

        public INotificationContentImage Image2 { get { return Images[1]; } }
        public INotificationContentText TextGroup2Field1 { get { return TextFields[3]; } }
        public INotificationContentText TextGroup2Field2 { get { return TextFields[4]; } }

        public INotificationContentImage Image3 { get { return Images[2]; } }
        public INotificationContentText TextGroup3Field1 { get { return TextFields[5]; } }
        public INotificationContentText TextGroup3Field2 { get { return TextFields[6]; } }
    }
}