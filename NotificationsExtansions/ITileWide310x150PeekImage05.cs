namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays an image, then transitions to show
    /// another image and two text fields.
    /// </summary>
    public interface ITileWide310x150PeekImage05 : IWide310x150TileNotificationContent
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
        INotificationContentText TextHeading { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}