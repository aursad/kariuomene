namespace NotificationsExtansions.ToastContent
{
    /// <summary>
    /// Type representing the alarm command properties which is contained within
    /// a toast notification content object.
    /// </summary>
    public interface IAlarmCommands
    {
        /// <summary>
        /// Whether the toast shows the snooze button.
        /// </summary>
        bool ShowSnoozeCommand { get; set; }

        /// <summary>
        /// The argument passed to the app when the snooze command is invoked.
        /// </summary>
        string SnoozeArgument { get; set; }

        /// <summary>
        /// Whether the toast shows the dismiss button.
        /// </summary>
        bool ShowDismissCommand { get; set; }

        /// <summary>
        /// The argument passed to the app when the dismiss command is invoked.
        /// </summary>
        string DismissArgument { get; set; }
    }
}