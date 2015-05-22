namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays a text field.
    /// </summary>
    public interface ITileWide310x150Text03 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }
    }
}