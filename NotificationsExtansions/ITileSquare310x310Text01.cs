namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a heading and nine text fields.
    /// </summary>
    public interface ITileSquare310x310Text01 : ISquare310x310TileNotificationContent
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

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody4 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody5 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody6 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody7 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody8 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody9 { get; }
    }
}