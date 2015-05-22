namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a heading and three text fields with a background image.
    /// </summary>
    public interface ITileSquare310x310ImageAndTextOverlay03 : ISquare310x310TileNotificationContent
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
        INotificationContentText TextBody1 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody2 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody3 { get; }
    }
}