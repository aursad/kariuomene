namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A Windows Phone large tile template that displays a monochrome icon with a badge and three lines of text.
    /// </summary>
    public interface ITileWide310x150IconWithBadgeAndText : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// The image for the icon.
        /// </summary>
        INotificationContentImage ImageIcon { get; }

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
    }
}