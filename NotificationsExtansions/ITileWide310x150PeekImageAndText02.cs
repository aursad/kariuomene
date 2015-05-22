namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A wide tile template that displays an image and a text field,
    /// then transitions to show the text field and four other text fields.
    /// </summary>
    public interface ITileWide310x150PeekImageAndText02 : IWide310x150TileNotificationContent
    {
        /// <summary>
        /// The main image on the tile.
        /// </summary>
        INotificationContentImage Image { get; }

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