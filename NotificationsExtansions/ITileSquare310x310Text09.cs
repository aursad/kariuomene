namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a heading which wraps to two lines,
    /// two more heading-sized text fields, and two text fields.
    /// </summary>
    public interface ITileSquare310x310Text09 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeadingWrap { get; }

        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeading1 { get; }

        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeading2 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody1 { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBody2 { get; }
    }
}