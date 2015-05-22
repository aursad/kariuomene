namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays an image, then transitions to show
    /// another image and a text field.
    /// </summary>
    public interface ITileWide310x150PeekImage06 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage ImageMain { get; }

        /// <summary>
        /// The secondary image on the tile.
        /// </summary>
        INotificationContentImage ImageSecondary { get; }

        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }
    }
}