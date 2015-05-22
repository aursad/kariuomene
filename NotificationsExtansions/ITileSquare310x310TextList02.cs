namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a list of three text fields that can wrap to a total of three lines.
    /// </summary>
    public interface ITileSquare310x310TextList02 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The text field for the first group in the list.
        /// </summary>
        INotificationContentText TextWrap1 { get; }

        /// <summary>
        /// The text field for the second group in the list.
        /// </summary>
        INotificationContentText TextWrap2 { get; }

        /// <summary>
        /// The  text field for the third group in the list.
        /// </summary>
        INotificationContentText TextWrap3 { get; }
    }
}