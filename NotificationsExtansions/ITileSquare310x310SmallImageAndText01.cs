namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays an image, a headline, a text field that can wrap to two lines,
    /// and a text field.
    /// </summary>
    public interface ITileSquare310x310SmallImageAndText01 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The image at the top of the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// The headline text.
        /// </summary>
        INotificationContentText TextHeading { get; }

        /// <summary>
        /// The middle text field that wraps to two lines.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }

        /// <summary>
        /// The lower text field.
        /// </summary>
        INotificationContentText TextBody { get; }
    }
}