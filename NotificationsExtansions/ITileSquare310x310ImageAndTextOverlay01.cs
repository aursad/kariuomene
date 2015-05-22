namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a heading with a background image.
    /// </summary>
    public interface ITileSquare310x310ImageAndTextOverlay01 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A caption for the image.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }
    }
}