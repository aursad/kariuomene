namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays five images - one main image,
    /// four smaller images in a row across the top, and a text caption.
    /// </summary>
    public interface ITileSquare310x310ImageCollectionAndText01 : ISquare310x310TileNotificationContent
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

        /// <summary>
        /// A caption for the image.
        /// </summary>
        INotificationContentText TextCaptionWrap { get; }
    }
}