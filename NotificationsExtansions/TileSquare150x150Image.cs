using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150Image : TileSquare150x150Base, ITileSquare150x150Image
    {
        public TileSquare150x150Image()
            : base(templateName: "TileSquare150x150Image", fallbackName: "TileSquareImage", imageCount: 1, textCount: 0)
        {
        }

        public INotificationContentImage Image { get { return Images[0]; } }
    }
}