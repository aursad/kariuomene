namespace NotificationsExtansions.TileContent
{
    /// <summary>
    /// A large square tile template that displays a list of three groups, each group having
    /// a heading, and two text fields.
    /// </summary>
    public interface ITileSquare310x310TextList01 : ISquare310x310TileNotificationContent
    {
        /// <summary>
        /// The heading for the first group in the list.
        /// </summary>
        INotificationContentText TextHeading1 { get; }

        /// <summary>
        /// The first text field for the first group in the list.
        /// </summary>
        INotificationContentText TextBodyGroup1Field1 { get; }

        /// <summary>
        /// The second text field for the first group in the list.
        /// </summary>
        INotificationContentText TextBodyGroup1Field2 { get; }

        /// <summary>
        /// The heading for the second group in the list.
        /// </summary>
        INotificationContentText TextHeading2 { get; }

        /// <summary>
        /// The first text field for the second group in the list.
        /// </summary>
        INotificationContentText TextBodyGroup2Field1 { get; }

        /// <summary>
        /// The second text field for the second group in the list.
        /// </summary>
        INotificationContentText TextBodyGroup2Field2 { get; }

        /// <summary>
        /// The heading for the third group in the list.
        /// </summary>
        INotificationContentText TextHeading3 { get; }

        /// <summary>
        /// The first text field for the third group in the list.
        /// </summary>
        INotificationContentText TextBodyGroup3Field1 { get; }

        /// <summary>
        /// The second text field for the third group in the list.
        /// </summary>
        INotificationContentText TextBodyGroup3Field2 { get; }
    }
}