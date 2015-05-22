namespace NotificationsExtansions.ToastContent
{
    /// <summary>
    /// A toast template that displays two text fields.
    /// </summary>
    public interface IToastText02 : IToastNotificationContent
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