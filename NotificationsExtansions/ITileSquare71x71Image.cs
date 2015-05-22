namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A small tile template that displays an image.
    /// </summary>
    public interface ITileSquare71x71Image : ISquare71x71TileNotificationContent
    {
        /// <summary>
        /// The image for the icon.
        /// </summary>
        INotificationContentImage Image { get; }
    }
}