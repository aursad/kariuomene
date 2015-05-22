namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays a text field.
    /// </summary>
    public interface ITileWide310x150Text04 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}