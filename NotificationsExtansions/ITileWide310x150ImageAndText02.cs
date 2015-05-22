namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays an image and two text captions.
    /// </summary>
    public interface ITileWide310x150ImageAndText02 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// The first caption for the image.
        /// </summary>
        INotificationContentText TextCaption1 { get; }

        /// <summary>
        /// The second caption for the image.
        /// </summary>
        INotificationContentText TextCaption2 { get; }
    }
}