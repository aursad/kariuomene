namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large tile template that displays seven text fields with one background image.
    /// </summary>
    public interface ITileSquare310x310BlockAndText02 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The background image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

        /// <summary>
        /// A large block text field.
        /// </summary>
        INotificationContentText TextBlock { get; }

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