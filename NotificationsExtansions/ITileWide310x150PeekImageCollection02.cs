namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays five images - one main image,
    /// and four square images in a grid, then transitions to show five
    /// text fields.
    /// </summary>
    public interface ITileWide310x150PeekImageCollection02 : ITileWide310x150ImageCollection
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
    }
}