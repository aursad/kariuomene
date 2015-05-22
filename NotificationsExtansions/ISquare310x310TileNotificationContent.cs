namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// Base large tile notification content interface.
    /// </summary>
    public interface ISquare310x310TileNotificationContent : ITileNotificationContent
    {
        /// <summary>
        /// Corresponding wide tile notification content should be a part of every large tile notification.
        /// </summary>
        IWide310x150TileNotificationContent Wide310x150Content { get; set; }

        /// <summary>
        /// Whether wide tile notification content needs to be added to pass
        /// validation.  Wide310x150 content is required by default.
        /// </summary>
        bool RequireWide310x150Content { get; set; }
    }
}