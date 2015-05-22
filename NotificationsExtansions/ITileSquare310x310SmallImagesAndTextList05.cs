namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a headline and a list of three groups, each group having
    /// an image and two text fields.
    /// </summary>
    public interface ITileSquare310x310SmallImagesAndTextList05 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The headline text.
        /// </summary>
        INotificationContentText TextHeading { get; }

        /// <summary>
        /// The image for the first group in the list.
        /// </summary>
        INotificationContentImage Image1 { get; }

        /// <summary>
        /// The first text field for the first group in the list.
        /// </summary>
        INotificationContentText TextGroup1Field1 { get; }

        /// <summary>
        /// The second text field for the first group in the list.
        /// </summary>
        INotificationContentText TextGroup1Field2 { get; }

        /// <summary>
        /// The image for the second group in the list.
        /// </summary>
        INotificationContentImage Image2 { get; }

        /// <summary>
        /// The first text field for the second group in the list.
        /// </summary>
        INotificationContentText TextGroup2Field1 { get; }

        /// <summary>
        /// The second text field for the second group in the list.
        /// </summary>
        INotificationContentText TextGroup2Field2 { get; }

        /// <summary>
        /// The image for the third group in the list.
        /// </summary>
        INotificationContentImage Image3 { get; }

        /// <summary>
        /// The first text field for the third group in the list.
        /// </summary>
        INotificationContentText TextGroup3Field1 { get; }

        /// <summary>
        /// The second text field for the third group in the list.
        /// </summary>
        INotificationContentText TextGroup3Field2 { get; }
    }
}