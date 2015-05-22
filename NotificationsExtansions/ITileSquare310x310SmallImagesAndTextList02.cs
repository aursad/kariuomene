namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a list of three groups, each group having an image,
    /// and a text field that can wrap to a total of three lines.
    /// </summary>
    public interface ITileSquare310x310SmallImagesAndTextList02 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The image for the first group in the list.
        /// </summary>
        INotificationContentImage Image1 { get; }

        /// <summary>
        /// The text field for the first group in the list.
        /// </summary>
        INotificationContentText TextWrap1 { get; }

        /// <summary>
        /// The image for the second group in the list.
        /// </summary>
        INotificationContentImage Image2 { get; }

        /// <summary>
        /// The text field for the second group in the list.
        /// </summary>
        INotificationContentText TextWrap2 { get; }

        /// <summary>
        /// The image for the third group in the list.
        /// </summary>
        INotificationContentImage Image3 { get; }

        /// <summary>
        /// The  text field for the third group in the list.
        /// </summary>
        INotificationContentText TextWrap3 { get; }
    }
}