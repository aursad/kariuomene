namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A square tile template that displays two text captions.
    /// </summary>
    public interface ITileSquare150x150Block : ISquare150x150TileNotificationContent
    {
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