using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310SmallImagesAndTextList02 : TileSquare310x310Base, ITileSquare310x310SmallImagesAndTextList02
    {
        public TileSquare310x310SmallImagesAndTextList02()
            : base(templateName: "TileSquare310x310SmallImagesAndTextList02", fallbackName: null, imageCount: 3, textCount: 3)
        {
        }

        public INotificationContentImage Image1 { get { return Images[0]; } }
        public INotificationContentText TextWrap1 { get { return TextFields[0]; } }

        public INotificationContentImage Image2 { get { return Images[1]; } }
        public INotificationContentText TextWrap2 { get { return TextFields[1]; } }

        public INotificationContentImage Image3 { get { return Images[2]; } }
        public INotificationContentText TextWrap3 { get { return TextFields[2]; } }
    }
}