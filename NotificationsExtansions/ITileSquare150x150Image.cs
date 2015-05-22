namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays an image.
    /// </summary>
    public interface ITileSquare150x150Image : ISquare150x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }
    }
}