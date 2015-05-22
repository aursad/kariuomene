namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays five text fields.
    /// </summary>
    public interface ITileWide310x150Text05 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody1 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody2 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody3 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody4 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody5 { get; }
    }
}