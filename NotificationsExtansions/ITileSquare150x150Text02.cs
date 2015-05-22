namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays two text fields.
    /// </summary>
    public interface ITileSquare150x150Text02 : ISquare150x150TileNotificationContent
    {
        /// <summary>
        /// A heading text field.
        /// </summary>
        INotificationContentText TextHeading { get; }

        /// <summary>
        /// A body text field.
        /// </summary>
        INotificationContentText TextBodyWrap { get; }
    }
}