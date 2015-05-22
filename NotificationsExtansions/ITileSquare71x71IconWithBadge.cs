namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A small tile template that displays a monochrome icon with a badge.
    /// </summary>
    public interface ITileSquare71x71IconWithBadge : ISquare71x71TileNotificationContent
    {
        /// <summary>
        /// The image for the icon.
        /// </summary>
        INotificationContentImage ImageIcon { get; }
    }
}