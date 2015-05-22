namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays an image and a text caption.
    /// </summary>
    public interface ITileSquare310x310ImageAndText01 : ISquare310x310TileNotificationContent
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