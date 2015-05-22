namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays three text fields.
    /// </summary>
    public interface ITileWide310x150BlockAndText02 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }

        /// <summary>
        /// A large block text field.
        /// </summary>
        INotificationContentText TextBlock { get; }

        /// <summary>
        /// The description under the large block text field.
        /// </summary>
        INotificationContentText TextSubBlock { get; }
    }
}