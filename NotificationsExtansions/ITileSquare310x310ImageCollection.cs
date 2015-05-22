namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays five images - one main image,
    /// and four smaller images in a row across the top.
    /// </summary>
    public interface ITileSquare310x310ImageCollection : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage ImageMain { get; }

        /// <summary>
        /// A small image on the tile.
        /// </summary>
        INotificationContentImage ImageSmall1 { get; }

        /// <summary>
        /// A small square image on the tile.
        /// </summary>
        INotificationContentImage ImageSmall2 { get; }

        /// <summary>
        /// A small square image on the tile.
        /// </summary>
        INotificationContentImage ImageSmall3 { get; }

        /// <summary>
        /// A small image on the tile.
        /// </summary>
        INotificationContentImage ImageSmall4 { get; }
    }
}