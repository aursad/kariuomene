namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays an image and two text captions.
    /// </summary>
    public interface ITileSquare310x310ImageAndText02 : ISquare310x310TileNotificationContent
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