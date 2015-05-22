namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays an image, then transitions to show
    /// two text fields.
    /// </summary>
    public interface ITileSquare150x150PeekImageAndText02 : ISquare150x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

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