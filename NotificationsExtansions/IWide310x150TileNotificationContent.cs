namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// Base wide tile notification content interface.
    /// </summary>
    public interface IWide310x150TileNotificationContent : ITileNotificationContent
    {
        /// <summary>
        /// Corresponding square tile notification content should be a part of every wide tile notification.
        /// </summary>
        ISquare150x150TileNotificationContent Square150x150Content { get; set; }

        /// <summary>
        /// Whether square tile notification content needs to be added to pass
        /// validation.  Square150x150 content is required by default.
        /// </summary>
        bool RequireSquare150x150Content { get; set; }
    }
}