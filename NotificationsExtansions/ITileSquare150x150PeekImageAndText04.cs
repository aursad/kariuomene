namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays an image, then transitions to
    /// show a text field.
    /// </summary>
    public interface ITileSquare150x150PeekImageAndText04 : ISquare150x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}