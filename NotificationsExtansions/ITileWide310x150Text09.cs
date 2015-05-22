namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays two text fields.
    /// </summary>
    public interface ITileWide310x150Text09 : IWide310x150TileNotificationContent
    {
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