namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays a text field.
    /// </summary>
    public interface ITileSquare150x150Text04 : ISquare150x150TileNotificationContent
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}