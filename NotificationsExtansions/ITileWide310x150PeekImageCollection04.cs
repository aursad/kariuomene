namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays five images - one main image,
    /// and four square images in a grid, then transitions to show a
    /// text field.
    /// </summary>
    public interface ITileWide310x150PeekImageCollection04 : ITileWide310x150ImageCollection
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}