namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A Windows Phone medium tile template that displays a monochrome icon with a badge.
    /// </summary>
    public interface ITileSquare150x150IconWithBadge : ISquare150x150TileNotificationContent
    {
        /// <summary>
        /// The image for the icon.
        /// </summary>
        INotificationContentImage ImageIcon { get; }
    }
}