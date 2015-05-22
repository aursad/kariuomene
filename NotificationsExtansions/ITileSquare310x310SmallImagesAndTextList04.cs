namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a list of three groups, each group having
    /// a heading, and one text field, which wraps to two lines followed by an image.
    /// </summary>
    public interface ITileSquare310x310SmallImagesAndTextList04 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The image for the first group in the list.
        /// </summary>
        INotificationContentImage Image1 { get; }

        /// <summary>
        /// The heading for the first group in the list.
        /// </summary>
        INotificationContentText TextHeading1 { get; }

        /// <summary>
        /// The first text field for the first group in the list.
        /// </summary>
        INotificationContentText TextWrap1 { get; }

        /// <summary>
        /// The image for the second group in the list.
        /// </summary>
        INotificationContentImage Image2 { get; }

        /// <summary>
        /// The heading for the second group in the list.
        /// </summary>
        INotificationContentText TextHeading2 { get; }

        /// <summary>
        /// The first text field for the second group in the list.
        /// </summary>
        INotificationContentText TextWrap2 { get; }

        /// <summary>
        /// The image for the third group in the list.
        /// </summary>
        INotificationContentImage Image3 { get; }

        /// <summary>
        /// The heading for the third group in the list.
        /// </summary>
        INotificationContentText TextHeading3 { get; }

        /// <summary>
        /// The first text field for the third group in the list.
        /// </summary>
        INotificationContentText TextWrap3 { get; }
    }
}