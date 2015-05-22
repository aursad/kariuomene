namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays five images - one main image,
    /// and four square images in a grid, then transitions to show two
    /// text fields.
    /// </summary>
    public interface ITileWide310x150PeekImageCollection01 : ITileWide310x150ImageCollection
    {
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