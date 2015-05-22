using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare71x71Image : TileSquare71x71Base, ITileSquare71x71Image
    {
        public TileSquare71x71Image()
            : base(templateName: "TileSquare71x71Image", fallbackName: null, imageCount: 1, textCount: 0)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }
    }
}