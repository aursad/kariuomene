namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays an image and a text field.
    /// </summary>
    public interface ITileWide310x150SmallImageAndText01 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }
    }
}