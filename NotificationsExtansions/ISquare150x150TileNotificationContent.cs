namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// Base square tile notification content interface.
    /// </summary>
    public interface ISquare150x150TileNotificationContent : ITileNotificationContent
    {
        /// <summary>
        /// Corresponding small tile notification content can be a part of every square tile notification.
        /// </summary>
        ISquare71x71TileNotificationContent Square71x71Content { get; set; }

        /// <summary>
        /// Whether small tile notification content needs to be added to pass
        /// validation.  Square71x71 content is not required by default.
        /// </summary>
        bool RequireSquare71x71Content { get; set; }
    }
}