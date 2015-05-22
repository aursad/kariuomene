using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310Image : TileSquare310x310Base, ITileSquare310x310Image
    {
        public TileSquare310x310Image()
            : base(templateName: "TileSquare310x310Image", fallbackName: null, imageCount: 1, textCount: 0)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }
    }
}