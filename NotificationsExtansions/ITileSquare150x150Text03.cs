namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays four text fields.
    /// </summary>
    public interface ITileSquare150x150Text03 : ISquare150x150TileNotificationContent
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
    }
}