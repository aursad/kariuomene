namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays an image.
    /// </summary>
    public interface ITileSquare310x310Image : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }
    }
}