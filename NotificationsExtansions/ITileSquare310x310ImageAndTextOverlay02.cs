namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a heading and a text field with a background image.
    /// </summary>
    public interface ITileSquare310x310ImageAndTextOverlay02 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A caption for the image.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}