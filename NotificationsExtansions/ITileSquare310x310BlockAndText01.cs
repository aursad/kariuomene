namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large tile template that displays a heading,
    /// six text fields grouped into three units,
    /// and two more text fields.
    /// </summary>
    public interface ITileSquare310x310BlockAndText01 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }

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
        /// A large block text field.
        /// </summary>
        INotificationContentText TextBlock { get; }

        /// <summary>
        /// The description under the large block text field.
        /// </summary>
        INotificationContentText TextSubBlock { get; }
    }
}