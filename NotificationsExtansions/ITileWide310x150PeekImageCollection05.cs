namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays five images - one main image,
    /// and four square images in a grid, then transitions to show an image
    /// and two text fields.
    /// </summary>
    public interface ITileWide310x150PeekImageCollection05 : ITileWide310x150ImageCollection
    {
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