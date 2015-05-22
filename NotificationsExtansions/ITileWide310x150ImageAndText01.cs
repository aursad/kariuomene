namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays an image and a text caption.
    /// </summary>
    public interface ITileWide310x150ImageAndText01 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A caption for the image.
        /// </summary>
        INotificationContentText TextCaptionWrap { get; }
    }
}