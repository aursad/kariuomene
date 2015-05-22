namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays four text fields.
    /// </summary>
    public interface ITileSquare150x150Text01 : ISquare150x150TileNotificationContent
    {
        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeading { get; }

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
    }
}