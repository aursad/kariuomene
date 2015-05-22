namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays an image.
    /// </summary>
    public interface ITileWide310x150Image : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }
    }
}