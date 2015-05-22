namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays six text fields.
    /// </summary>
    public interface ITileWide310x150BlockAndText01 : IWide310x150TileNotificationContent
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
        /// A large block text field.
        /// </summary>
        INotificationContentText TextBlock { get; }

        /// <summary>
        /// The description under the large block text field.
        /// </summary>
        INotificationContentText TextSubBlock { get; }
    }
}